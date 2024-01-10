using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportInvoice
    {
        private List<Laptop> laptops = new List<Laptop>();
        public List<Laptop> Laptops
        {
            get { return laptops; }
            set { laptops = value; }
        }
        private Staff warehouseKeeper = new Staff();
        public Staff WarehouseKeeper
        {
            get { return warehouseKeeper; }
            set { warehouseKeeper = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private Provider provider = new Provider();
        public Provider Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        private DateTime importDate;
        public DateTime ImportDate
        {
            get { return importDate; }
            set { importDate = value; }
        }
        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
