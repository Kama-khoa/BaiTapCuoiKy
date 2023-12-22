﻿using System;
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
        public void insert (Customer customer)
        {
           CustomerDAL.Instance.insert(customer);
        }
        public bool update(Customer customer)
        {
            return CustomerDAL.Instance.update(customer);
        }
    }
}
