using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;

namespace Automaten.Guis
{
    internal class GUI
    {
        public ConsoleKeyInfo choice;
        private string dictionaryKeyChoice;
        public void MainMenu(Dictionary<string, Product> products)
        {
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("                     Vending");
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("1. Pick product");
            Console.WriteLine("2. Contact admin");
            Console.WriteLine("");
            UserMainMenuChoice(products);

        }
        public void ProductMenu(Dictionary<string,Product> products)
        {
            Console.WriteLine("----------**********#Products#**********----------");
            foreach (KeyValuePair<string,Product> p in products)
            {
                Console.WriteLine(p.Key + ". " + p.Value);
            }
            UserProductMenuChoice(products);
        }
        public void UserMainMenuChoice(Dictionary<string, Product> products)
        {
            Console.WriteLine("Choose your number");
            choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    MenuClear();
                    ProductMenu(products);

                    break;
                case ConsoleKey.D2:
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Error");
                    Thread.Sleep(200);
                    break;
            }
        }
        public void UserProductMenuChoice(Dictionary<string, Product> products)
        {
            Console.WriteLine("Select the product you want to buy");
            dictionaryKeyChoice = Console.ReadLine();
            switch (dictionaryKeyChoice)
            {
                case "A1":
                    break;
                default:
                    break;
            }
        }
        public void MenuClear()
        {
            Console.Clear();
        }
    }
}
