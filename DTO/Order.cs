using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        private int order_id;

        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }

        private string customer_id;

        public string Customer_id
        {
            get { return customer_id; }
            set { customer_id = value; }
        }

        private string accoutant_id;
        public string Accoutant_id
        {
            get { return accoutant_id; }
            set { accoutant_id = value; }
        }

        private string seller_id;
        public string Seller_id
        {
            get { return seller_id; }
            set { seller_id = value; }
        }

        private DateTime order_date;
        public DateTime Order_date
        {
            get { return order_date; }
            set { order_date = value; }
        }

        private int statusInt = 0;
        public int StatusInt
        {
            get { return statusInt; }
            set { statusInt = value; }
        }

        private string statusString = "Chưa thanh toán";
        public string StatusString
        {
            get { return statusString; }
            set { statusString = value; }
        }

        private void setStatusString()
        {
            switch (statusInt)
            {
                case 0:
                    statusString = "Đang xử lý";
                    break;
                case 1:
                    statusString = "Đã thanh toán";
                    break;
                case 2:
                    statusString = "Hủy";
                    break;
            }
        }
        private void setStatusInt()
        {
            switch (statusString)
            {
                case "Đang xử lý":
                    statusInt = 0;
                    break;
                case "Đã thanh toán":
                    statusInt = 1;
                    break;
                case "Hủy":
                    statusInt = 2;
                    break;
            }
        }

        private DateTime? update_status_time;
        public DateTime? UpdateStatusTime
        {
            get { return update_status_time; }
            set { update_status_time = value; }
        }

        private int paymentInt = 0;
        public int PaymentInt
        {
            get { return paymentInt; }
            set { paymentInt = value; }
        }

        private string paymentString = "Tiền mặt";
        public string PaymentString
        {
            get { return paymentString; }
            set { paymentString = value; }
        }

        private void setPaymentString()
        {
            switch (paymentInt)
            {
                case 0:
                    paymentString = "Tiền mặt";
                    break;
                case 1:
                    paymentString = "Chuyển khoản";
                    break;
            }
        }
        private void setPaymentInt()
        {
            switch (paymentString)
            {
                case "Tiền mặt":
                    paymentInt = 0;
                    break;
                case "Chuyển khoản":
                    paymentInt = 1;
                    break;
            }
        }
    }
}
