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
        public void Title()
        {
            string Progressbar = "Vending Machine";
            string title = "";
            foreach (char c in Progressbar)
            {
                title += c;
                Console.Title = title;
                Thread.Sleep(75);
            }
        }
        public void MainMenu(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            MenuClear();
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("                  Vending Machine");
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("1. Pick product");
            Console.WriteLine("2. Contact admin");
            Console.WriteLine("");
            UserMainMenuChoice(products, moneyBox);

        }
        private void ProductMenu(Dictionary<string, Product> products)
        {
            MenuClear();
            Console.WriteLine("----------**********#Products#**********----------");
            foreach (KeyValuePair<string, Product> p in products)
            {
                Console.WriteLine(p.Key + ". " + p.Value.Name + "   Costs: " + p.Value.Cost + " Dollars");
            }

        }
        private void AdminMenu()
        {
            MenuClear();
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("                      Admins  ");
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("1. Change Product");
            Console.WriteLine("2. Restock Products");
            Console.WriteLine("3. Empty Money Box");
            Console.WriteLine("");
            AdminMenuChoice();

        }
        private void UserMainMenuChoice(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            Console.WriteLine("Choose your number");
            choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    ProductMenu(products);

                    UserProductMenuChoice(products, moneyBox);
                    break;
                case ConsoleKey.D2:
                    AdminLogin();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Error");
                    Thread.Sleep(200);
                    break;
            }
        }
        private void UserProductMenuChoice(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            Console.WriteLine("Insert money");
            int money = int.Parse(Console.ReadLine());
            moneyBox.Pay(money);
            Console.WriteLine("Select the product you want to buy");
            dictionaryKeyChoice = Console.ReadLine();
            switch (dictionaryKeyChoice)
            {
                case "A1":
                    Console.WriteLine(moneyBox.ReturnRestOfMoney(products["A1"]));
                    Thread.Sleep(5000);
                    break;
                case "A2":
                    Console.WriteLine(moneyBox.ReturnRestOfMoney(products["A2"]));
                    Thread.Sleep(5000);
                    break;
                case "A3":
                    Console.WriteLine(moneyBox.ReturnRestOfMoney(products["A3"]));
                    Thread.Sleep(5000);
                    break;
                case "B1":
                    Console.WriteLine(moneyBox.ReturnRestOfMoney(products["B1"]));
                    Thread.Sleep(5000);
                    break;
                case "B2":
                    Console.WriteLine(moneyBox.ReturnRestOfMoney(products["B2"]));
                    Thread.Sleep(5000);
                    break;
                default:
                    break;
            }

        }
        private void AdminMenuChoice()
        {
            Console.Write("Choose a number: ");
            choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.D1:

                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.D3:

                    break;
                default:
                    AdminMenuChoice();
                    break;
            }
        }
        private void AdminLogin()
        {
            Console.WriteLine("Admin contacted");
            Thread.Sleep(2000);
            Console.WriteLine("Type Login code");
            string code = Console.ReadLine();
            if (code == "AdminPassword")
            {
                AdminMenu();
            }
            else
            {

            }
        }
        //Private method to clear the ConsoleWindow
        private void MenuClear()
        {
            Console.Clear();
        }
    }
}
