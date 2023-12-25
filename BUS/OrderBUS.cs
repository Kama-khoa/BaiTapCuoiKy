using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class OrderBUS
    {
        private static OrderBUS instance = new();
        public static OrderBUS Instance
        {
            get {  return instance; }
        }
        public List<Order> GetOrders()
        {
           return OrderDAL.Instance.GetOrders();
        }
    }
}