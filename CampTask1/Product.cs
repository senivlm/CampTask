using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class Product
    {
        public string Name { get; set; }
        private int price;
        private int weight;
        public int Price
        {
            get { return price; }
            set 
            { 
                if(value < 0)
                {
                    throw new ArgumentException();
                }
                price = value; 
            }
        }
        public int Weight
        {
            get { return weight; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                weight = value; 
            }
        }

        public Product(): this(null, default, default)
        {

        }
        public Product(string name, int price, int weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}; Price: {1}; Weight: {2}", Name, Price, Weight);
        }
        public void Parse(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            string[] arr = str.Split(' ');
            Name = arr[0];
            if(!int.TryParse(arr[1], out price))
            {
                throw new ArgumentException();
            }
            if(!int.TryParse(arr[2], out weight))
            {
                throw new ArgumentException();
            }

        }
        public virtual void IncreasePrice(int percentage)
        {
            Price = Price + (Price * percentage) / 100 ;
        }
        public virtual void DecreasePrice(int percentage)
        {
            Price = Price - (Price * percentage) / 100;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}; Price: {Price}; Weight: {Weight}");            
        }
    }
}
    