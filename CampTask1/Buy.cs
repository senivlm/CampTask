using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class Buy: Product
    {
        public int Count { get; set; }
        private int totalPrice;
        private int totalWeight;

        public int TotalPrice
        {
            get 
            {
                int price = Price;
                totalPrice = price * Count;
                return totalPrice; 
            }
        }

        public int TotalWeight
        {
            get
            {
                int weight = Weight;
                totalWeight = weight * Count;
                return totalWeight;
            }
        }
        
    }
}
