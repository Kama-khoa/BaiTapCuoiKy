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
        public List<Order> GetOrders()
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
                    order.Order_id = reader.GetInt32("order_id");
                    order.Customer_id = reader.GetString("customer_id");
                    order.Accoutant_id = reader.GetString("accoutant_id");
                    order.Seller_id = reader.GetString("seller_id");
                    order.Order_date = reader.GetDateTime("order_date");
                    order.StatusInt = reader.GetInt32("status");
                    order.UpdateStatusTime = reader.GetDateTime("update_status_time");
                    order.PaymentInt = reader.GetInt32("payment");
                    list.Add(order);
                }
            }
            conn.Close();
            return list;
        }

    }
}