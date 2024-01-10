using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Data.Common;
using System.Collections;

namespace DAL
{
    public class StaffDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect(); 
        private static StaffDAL instance=new();
        public static StaffDAL Instance
        {
            get { return instance; }
        }
        public List<Staff> get()
        {
            List<Staff> list = new List<Staff>();
            conn.Open();
            using (var cmd = new SqlCommand("GetStaffData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();           
                while (reader.Read())
                {
                    Staff staff = new Staff();
                    staff.ID =reader.GetInt32("staff_id");
                    staff.Name= reader.GetString("staff_name");
                    staff.Username= reader.GetString("username");
                    staff.Password= reader.GetString("password");
                    staff.RoleInt = reader.GetInt32("role");
                    staff.Password = MD5Security.Decrypt(staff.Password, "20012004", true);
                    list.Add(staff);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(Staff staff)
        {
            staff.Password = MD5Security.Encrypt(staff.Password,"20012004",true);
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertStaffData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@staff_name", SqlDbType.NVarChar).Value = staff.Name;
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = staff.Username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = staff.Password;
                    cmd.Parameters.Add("@role", SqlDbType.Int).Value = staff.RoleInt;
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
        public bool update(Staff staff)
        {
            staff.Password = MD5Security.Encrypt(staff.Password, "20012004", true);
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateStaffData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = staff.ID;
                    cmd.Parameters.Add("@staff_name", SqlDbType.NVarChar).Value = staff.Name;
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = staff.Username;
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = staff.Password;
                    cmd.Parameters.Add("@role", SqlDbType.Int).Value = staff.RoleInt;
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
        public bool delete(Staff staff)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("DeleteStaffData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = staff.ID;
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
        public Staff GetSeller(Staff seller)
        {
            conn.Open();
            using (var cmd = new SqlCommand("GetSellerByID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@seller_id", SqlDbType.Int).Value = seller.ID;

                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    seller.Name = reader.GetString("staff_name");
                    seller.RoleInt = reader.GetInt32("role");
                }
            }
            conn.Close();
            return seller;
        }
        public Staff GetAccountant(Staff acc)
        {
            conn.Open();
            using (var cmd = new SqlCommand("GetAccountantByID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@accountant_id", SqlDbType.Int).Value = acc.ID;

                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    acc.Name = reader.GetString("staff_name");
                    acc.RoleInt = reader.GetInt32("role");
                }
            }
            conn.Close();
            return acc;
        }
    }
}
