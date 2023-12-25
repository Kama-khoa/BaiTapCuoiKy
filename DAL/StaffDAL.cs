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
            using (var cmd = new SqlCommand("GetStaff", conn))
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
                    list.Add(staff);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(Staff staff)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertStaff", conn))
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
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateStaff", conn))
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
                using (var cmd = new SqlCommand("DeleteStaff", conn))
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
        
    }
}
