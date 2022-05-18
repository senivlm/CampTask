using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampTask1
{
    class Storage
    {
        public Product[] products;
        public void InitializationForUsers()
        {
            products = new Product[100];
            int i = 0 ;
            while (true)
            {
                bool flag = true;
                Console.WriteLine();
                Console.WriteLine("What do you want to add? (1 - meat, 2 - dairy product, 0 - nothing)");              
                int choice1;
                do
                {
                    Console.Write("Your choice: ");
                    choice1 = Convert.ToInt32(Console.ReadLine());
                } while (choice1 != 0 && choice1 != 1 && choice1 != 2);
                switch (choice1)
                {
                    case 1:                       
                        CreateMeat(i);
                        break;
                    case 2:
                        CreateDairyProduct(i);
                        break;
                    default:
                        flag = false;
                        break;
                }

                if (flag == false)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
        }
        private void CreateMeat(int i)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose category (top grade, first grade, second grade) ");
            string chooseCategory;
            do
            {
                Console.Write("Category: ");
                chooseCategory = Console.ReadLine().ToLower();
            } while (chooseCategory != "top grade" && chooseCategory != "first grade" && chooseCategory != "second grade");
            MeatTools.Category category;
            switch (chooseCategory)
            {
                case "top grade":
                    category = MeatTools.Category.TopGrade;
                    break;
                case "first grade":
                    category = MeatTools.Category.FirstGrade;
                    break;
                case "second grade":
                    category = MeatTools.Category.SecondGrade;
                    break;
                default:
                    category = 0;
                    break;
            }

            Console.WriteLine("Choose type (mutton, veal, pork, chicken) ");
            string chooseType;
            do
            {
                Console.Write("Type: ");
                chooseType = Console.ReadLine().ToLower();

            } while (chooseType != "mutton" && chooseType != "veal" && chooseType != "pork" && chooseType != "chicken");
            MeatTools.Type type;
            switch (chooseType)
            {
                case "mutton":
                    type = MeatTools.Type.Mutton;
                    break;
                case "veal":
                    type = MeatTools.Type.Veal;
                    break;
                case "pork":
                    type = MeatTools.Type.Pork;
                    break;
                case "chicken":
                    type = MeatTools.Type.Chicken;
                    break;
                default:
                    type = 0;
                    break;
            }

            products[i] = new Meat(name, price, weight, category, type);
        }
        private void CreateDairyProduct(int i)
        {
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Price: ");
            int price1 = int.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            int weight1 = int.Parse(Console.ReadLine());
            Console.Write("Expiration date: ");
            int expirationDate = int.Parse(Console.ReadLine());
            products[i] = new DairyProducts(name1, price1, weight1, expirationDate);
        }
        public void Initialization()
        {
            products = new Product[5];
            products[0] = new Meat("meat1", 200, 500, MeatTools.Category.TopGrade, MeatTools.Type.Mutton);
            products[1] = new Meat("meat2", 400, 1000, MeatTools.Category.SecondGrade, MeatTools.Type.Pork);
            products[2] = new DairyProducts("milk", 50, 100, 30);
            products[3] = new DairyProducts("cheese", 200, 100, 90);
            products[4] = new Meat("meat3", 400, 500, MeatTools.Category.FirstGrade, MeatTools.Type.Veal);
        }
        public void PrintInfo()
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].PrintInfo();
                Console.WriteLine();
            }            
        }
        public void PrintMeatProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                if ( products[i] is Meat)
                {
                    products[i].PrintInfo();
                }
            }
        }
        public void IncreasePrice(int percentage)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].IncreasePrice(percentage);
            }
        }
        public void DecreasePrice(int persentage)
        {
            for (int i = 0; i < products.Length; i++)
            {
                products[i].DecreasePrice(persentage);
            }
        }
        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < products.Length)
                {
                    return products[index];
                }
                else
                {
                    return null;
                }

            }
            set
            {
                if (index >= 0 && index < products.Length)
                {
                    products[index] = value;
                }
                else
                {
                    products[index] = null;
                }

            }
        }

    }
}
