using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class DairyProducts: Product
    {
        private int expirationDate;
        public int ExpirationDate
        {
            get { return expirationDate; }
            set 
            {
                if (value > 0)
                    expirationDate = value;
                else
                    expirationDate = 0;
            }
        }

        public DairyProducts(): this (null, default, default, default)
        {

        }
        public DairyProducts(string name, int price, int weight, int expirationDate): base(name, price, weight)
        {
            ExpirationDate = expirationDate;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}; Price: {1}; Weight: {2}; Expiration date: {3}", Name, Price, Weight, ExpirationDate);
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Expiration date: {ExpirationDate}");
        }   
        public override void IncreasePrice(int percentage)
        {
            int parameter = DefinePercentage(ExpirationDate);
            Price = Price + (Price * percentage) / 100 + (Price * parameter) / 100;
        }
        public override void DecreasePrice(int percentage)
        {
            int parameter = DefinePercentage(ExpirationDate);
            Price = Price - (Price * percentage) / 100 + (Price * parameter) / 100;
        }
        private int DefinePercentage(int expirationDate)
        {
            if (expirationDate >= 0 && expirationDate <= 31)
            {
                return 40;
            }
            else if (expirationDate >= 31 && expirationDate <= 90)
            {
                return 30;
            }
            else
            {
                return 15;
            }
        }
    }
}
