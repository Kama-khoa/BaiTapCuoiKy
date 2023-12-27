using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CustomerDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static CustomerDAL instance = new();
        public static CustomerDAL Instance
        {
            get { return instance; }
        }
        public void Open()
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        public List<Customer> get()
        {
            List<Customer> list = new List<Customer>();

            Open();
            using (var cmd = new SqlCommand("GetStaff", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.ID = reader.GetInt32("customer_id");
                    customer.Name = reader.GetString("customer_name");
                    customer.Phone= reader.GetString("phone");
                    customer.Address = reader.GetString("address");
                    list.Add(customer);
                }
            }
            Close();
            return list;
        }
        public bool Check(Customer customer)
        {
            Open();
            SqlCommand command = new SqlCommand("select phone from customers ", conn);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                if (customer.Phone == dr["phone"])
                {
                    return true;
                }
            }
            Close();
            return false;

        }
        public bool insert (Customer customer)
        {
            try
            {
                Open ();
                using (var cmd = new SqlCommand("addKhachHang", conn))
                {   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = customer.Name;
                    cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = customer.Phone;
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = customer.Address;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(Customer customer)
        {
            try
            {
                Open();
                using (var cmd = new SqlCommand("updateKhachHang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.ID;
                    cmd.Parameters.Add("@customer_name", SqlDbType.NVarChar).Value = customer.Name;
                    cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = customer.Phone;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customer.Address;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(Customer customer)
        {
            try
            {
                Open();
                using (var cmd = new SqlCommand("deleteKhachHang", conn))
                {
                    cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.ID;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
