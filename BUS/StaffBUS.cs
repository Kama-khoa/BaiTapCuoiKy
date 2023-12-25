using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class StaffBUS
    {
        private static StaffBUS instance = new();
        public static StaffBUS Instance
        {
            get { return instance; }
        }
        public bool checkLogInfo(Staff staff)
        {
            foreach (Staff item in StaffDAL.Instance.get())
            {
                if (staff.Username == item.Username && staff.Password == item.Password)
                {
                    staff = item;
                    return true;
                }   
            }
            return false;
        }
        public List<Staff> get()
        {
            return  StaffDAL.Instance.get();
        }
        public bool insert(Staff staff)
        {
            return StaffDAL.Instance.insert(staff);
        }
        public bool update(Staff staff) {
            return StaffDAL.Instance.update(staff);
        }
        public bool delete(Staff staff)
        {
            return StaffDAL.Instance.delete(staff);
        }
    }
}
