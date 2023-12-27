using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Manufactory
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string website;
        public string Website
        {
            get { return website; }
            set {  website = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
