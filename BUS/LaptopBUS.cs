using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class LaptopBUS
    {
        private static LaptopBUS instance = new();
        public static LaptopBUS Instance
        {
            get { return instance; }
        }
        public List<Laptop> get()
        {
            return LaptopDAL.Instance.get();
        }
        public bool insert(Laptop laptop)
        {
            return LaptopDAL.Instance.insert(laptop);
        }
        public bool update(Laptop laptop)
        {
            return LaptopDAL.Instance.update(laptop);
        }
        public bool delete(Laptop laptop)
        {
            return LaptopDAL.Instance.delete(laptop);
        }
        
    }
}
