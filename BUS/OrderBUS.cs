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
        public List<Order> get()
        {
           return OrderDAL.Instance.get();
        }
        public bool insert(Order order)
        {
            return OrderDAL.Instance.insert(order);
        }
        public bool update( Order order)
        {
            return OrderDAL.Instance.update(order);
        }
        public bool delete(Order order)
        {
            return OrderDAL.Instance.delete(order);
        }
        public Order getOrderByID(int ID)
        {
            return OrderDAL.Instance.getOrderByID(ID);
        }
    }
}