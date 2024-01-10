using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProviderDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static ProviderDAL instance = new();
        public static ProviderDAL Instance
        {
            get { return instance; }
        }
        public List<Provider> get()
        {
            List<Provider> list = new List<Provider>();
            conn.Open();
            using (var cmd = new SqlCommand("GetProvider", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Provider provider = new Provider();
                    provider.ID = reader.GetInt32("provider_id");
                    provider.Name = reader.GetString("provider_name");
                    provider.Address = reader.GetString("address");
                    provider.Phone = reader.GetString("phone");
                    list.Add(provider);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(Provider provider)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertProvider", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = provider.Name;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = provider.Address;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = provider.Phone;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(Provider provider)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateProvider", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = provider.ID;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = provider.Name;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = provider.Address;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = provider.Phone;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(Provider provider)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("DeleteProvider", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = provider.ID;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}