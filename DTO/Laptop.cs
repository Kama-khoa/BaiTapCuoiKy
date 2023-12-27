using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Laptop
    {
        private int id;
        public int ID { 
            get { return id; } 
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Manufactory manufactory;
        public Manufactory Manufactory
        {
            get { return manufactory; }
            set { manufactory = value; }
        }
        private Category category;
        public Category Category
        {
            get { return category; }
            set { category = value; }
        }
        private string cpu;
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
        private string ram;
        public string Ram
        {
            get { return ram; }
            set {  ram = value; }
        }
        private string hardDriver;
        public string HardDriver
        {
            get { return hardDriver; }
            set { hardDriver = value; }
        }
        private string vga;
        public string VGA
        {
            get { return vga; }
            set { vga = value; }
        }
        private string display;
        public string Display
        {
            get { return display; }
            set { display = value; }
        }
        private string battery;
        public string Battery
        {
            get { return battery; }
            set {  battery = value; }
        }
        private string os;
        public string OS
        {
            get { return os; }
            set {  os = value; }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set {  weight = value; }
        }
        private string material;
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string port;
        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string connection;
        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        private string security;
        public string Security
        {
            get { return security; }
            set {  security = value; }
        }
        private string keyboard;
        public string Keyboard
        {
            get { return keyboard; }
            set {  keyboard = value; }
        }
        private string audio;
        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }
        private string size;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }
        private string quantityInStock;
        public string QuantityInStock
        {
            get { return quantityInStock; }
            set {  quantityInStock = value; }
        }
        private string quantityBought;
        public string QuantityBought
        {
            get { return quantityBought; }
            set { quantityBought = value; }
        }

    }
}