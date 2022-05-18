using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class Meat: Product
    {
        public MeatTools.Category category { get; set; }
        public MeatTools.Type type { get; set; }
        public Meat() : this(null, default, default, default, default)
        {

        }
        public Meat(string name, int price, int weight, MeatTools.Category category, MeatTools.Type type) : base(name, price, weight)
        {
            this.category = category;
            this.type = type;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}; Price: {1}; Weight: {2}: Category: {3}; Type: {4}.", Name, Price, Weight, category, type);
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Category: {category}   |   Type: {type}");
        }
        public override void IncreasePrice(int percentage)
        {
            Price =  Price + (Price * percentage) / 100 + (Price * (int)category) / 100;
        }
        public override void DecreasePrice(int percentage)
        {
            Price = Price - (Price * percentage) / 100 + (Price * (int)category) / 100;
        }
    }
}
