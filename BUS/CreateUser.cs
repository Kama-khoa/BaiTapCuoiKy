using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CreateUser
    {
        public static string createUsername(string text)
        {
            string username = "";
            string str = text;// tbHoTen.Text;
            DateTime dateTime = DateTime.Now;
            for (int i = str.Length - 1; i > -1; i--)
            {
                if (str[i] == ' ')
                {
                    str = str.Remove(0, i + 1);
                    break;
                }
            }
            username = Convert(str) + dateTime.Minute + dateTime.Second + dateTime.Hour;
            return username;
        }
        public static string createPassword()
        {
            char[] password = new char[8];
            string charSet = "";
            System.Random random = new Random();
            charSet += "abcdefghijklmnopqursuvwxyz";
            charSet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            charSet += "123456789";
            charSet += @"!@£$%^&*()#€";
            for (int i = 0; i < 8; i++)
            {
                password[i] = charSet[random.Next(charSet.Length - 1)];
            }
            return string.Join(null, password);
        }

        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string Convert(string str)
        {

            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
    }
}
