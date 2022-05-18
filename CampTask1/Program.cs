using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var buy1 = new Buy();
                buy1.Name = "Table";
                buy1.Price = 10000;
                buy1.Weight = 50;
                buy1.Count = 3;
                Check.CheckAll(buy1);
                Console.WriteLine();

                var meat = new Meat("asdf", 200, 500, MeatTools.Category.TopGrade, MeatTools.Type.Mutton);
                meat.IncreasePrice(50);
                Console.WriteLine(meat.Price);

                var storage1 = new Storage();
                //storage1.InitializationForUsers();
                storage1.Initialization();
                storage1.PrintInfo();
                Console.WriteLine();

                storage1[4] = new DairyProducts("milk1", 50, 100, 30);
                storage1.PrintMeatProducts();
                Console.WriteLine();
                Console.WriteLine();

                storage1.IncreasePrice(50);
                storage1.PrintInfo();

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument null exception occurred!");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Argument exception occurred!");
            }
            catch (Exception)
            {
                Console.WriteLine("Some exception occurred!");
            }

        }
    }
}
