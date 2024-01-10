using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance = new();
        public static CustomerBUS Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public List<Customer> get()
        {
            return CustomerDAL.Instance.get();
        }
        public bool insert(Customer customer)
        {
            return CustomerDAL.Instance.insert(customer);
        }
        public bool update(Customer customer)
        {
            return CustomerDAL.Instance.update(customer);
        }
        public bool delete(Customer customer)
        {
            return CustomerDAL.Instance.delete(customer);
        }
        public bool CheckPhone(Customer customer)
        {
            foreach (Customer item in CustomerDAL.Instance.get())
            {
                if (customer.Phone == item.Phone )
                {
                    customer = item;
                    return true;
                }
            }
            return false;
        }
        public Customer getCustomer(Customer cus)
        {
            return CustomerDAL.Instance.GetCustomer(cus);
        }
    }
}