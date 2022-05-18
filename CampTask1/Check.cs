using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class Check
    {
        static public void CheckAll(Buy buy)
        {
            Console.WriteLine($"Product: {buy.Name} \nCount: {buy.Count}  \nTotal price: {buy.TotalPrice}  \nTotalWeight: {buy.TotalWeight}");
        }
    }
}
