using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.Common;
using System.Collections;

namespace DAL
{
    public class OrderDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static OrderDAL instance = new();
        public static OrderDAL Instance
        {
            get { return instance; }
        }
        public List<Order> get()
        {
            List<Order> list = new List<Order>();
            conn.Open();
            using (var cmd = new SqlCommand("GetOrder", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order();
                    order.ID = reader.GetInt32("order_id");
                    order.Customer = new Customer();
                    order.Customer.ID = reader.GetInt32("customer_id");
                    order.Accountant = new Staff();
                    order.Accountant.ID = reader.GetInt32("accoutant_id");
                    order.Seller = new Staff();
                    order.Seller.ID = reader.GetInt32("seller_id");
                    order.Order_date = reader.GetDateTime("order_date");
                    order.StatusInt = reader.GetInt32("status");
                    order.PaymentInt = reader.GetInt32("payment");
                    try
                    {
                        if (reader.GetDateTime("update_status_time") != null)
                            order.UpdateStatusTime = reader.GetDateTime("update_status_time");
                    }
                    catch { }
                    list.Add(order);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(Order order)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = order.Customer.ID;
                    cmd.Parameters.Add("@seller_id", SqlDbType.Int).Value = order.Seller.ID;
                    cmd.Parameters.Add("@order_date", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SqlCommand("getNewOrderID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        order.ID = reader.GetInt32("max_id");
                    }
                    reader.Close();
                }
                foreach (Laptop item in order.Laptop)
                {
                    insertDetail(item, order);
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(Order order)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = order.ID;
                    cmd.Parameters.Add("@payment", SqlDbType.Int).Value = order.PaymentInt;
                    cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = order.StatusInt;
                    cmd.Parameters.Add("@update_status_date", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.Parameters.Add("@accountant_id", SqlDbType.Int).Value = order.Accountant.ID;
                    cmd.ExecuteNonQuery();
                }
                if (order.StatusInt == 0)
                {
                    foreach (var laptop in order.Laptop)
                    {
                        LaptopDAL.Instance.reStock(laptop);
                    }
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(Order order)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("DeleteOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Order_id", SqlDbType.Int).Value = order.ID;
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
        
        
        public void insertDetail(Laptop laptop, Order order)
        {
            try
            {
                using (var cmd = new SqlCommand("InsertOrderDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = order.ID;
                    cmd.Parameters.Add("@laptop_id", SqlDbType.Int).Value = laptop.ID;
                    cmd.Parameters.Add("@quantity_bought", SqlDbType.Int).Value = laptop.QuantityBought;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

            }
        }
        public Order getOrderByID(int ID)
        {
            Order order= new Order();
            conn.Open();
            using (var cmd = new SqlCommand("getOrderByID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    order.ID = reader.GetInt32("order_id");
                    order.Customer = new Customer();
                    order.Customer.ID = reader.GetInt32("customer_id");
                    order.Accountant = new Staff();
                    order.Accountant.ID = reader.GetInt32("accoutant_id");
                    order.Seller = new Staff();
                    order.Seller.ID = reader.GetInt32("seller_id");
                    order.Order_date = reader.GetDateTime("order_date");
                    order.StatusInt = reader.GetInt32("status");
                    order.PaymentInt = reader.GetInt32("payment");
                    try
                    {
                        order.UpdateStatusTime = reader.GetDateTime("update_status_time");
                    }
                    catch { }   
                }
                reader.Close();
            }
            order.Customer = CustomerDAL.Instance.GetCustomer(order.Customer);
            order.Accountant = StaffDAL.Instance.GetAccountant(order.Accountant);
            order.Seller=StaffDAL.Instance.GetSeller(order.Seller);
            using (var cmd = new SqlCommand("getOrderDetailByID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Laptop laptop = new Laptop();
                    laptop = LaptopDAL.Instance.getLaptopByID(reader.GetInt32("laptop_id"));
                    laptop.QuantityBought= reader.GetInt32("quantity");
                    order.Laptop.Add(laptop);
                }
                reader.Close ();
            }

            conn.Close();
            return order;
        }
        
    }
}