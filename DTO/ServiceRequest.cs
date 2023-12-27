using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServiceRequest
    {
        private Order order=new Order();
        public Order Order { 
            get { return order; } 
            set { order = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string decription;
        public string Decription
        {
            get { return decription; }
            set {  decription = value; }
        }
        private int typeINT;
        public int TypeINT
        {
            get { return typeINT; }
            set {  typeINT = value; }
        }
        private string typeSTRING;
        public string TypeSTRING
        {
            get { return typeSTRING; }
            set { typeSTRING = value; }
        }
        private int statusINT;
        public int StatusINT
        {
            get { return statusINT; }
            set {  statusINT = value; }
        }
        private string statusSTRING;
        public string StatusSTRING
        {
            get { return statusSTRING; }
            set { statusSTRING = value; }
        }
        private int rating;
        public int Rating
        {
            get { return rating; }
            set {  rating = value; }
        }
        private DateTime updateStatusTime;
        public DateTime UpdateStatusTime
        {
            get { return updateStatusTime; }
            set { updateStatusTime = value; }
        }

    }
}
