using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;
using Automaten;

namespace Automaten.Guis
{
    internal class GUI
    {
        //public ConsoleKeyInfo Variable, used to checks users input key
        public ConsoleKeyInfo choice;
        //private String variable, used to check users choice 
        private string dictionaryKeyChoice;

        //A public method to set the Title of the Console Window
        public void Title()
        {
            //2 strings, one to the name you want as title, the other to use in the for each
            string Progressbar = "Vending Machine";
            string title = "";
            //Foreach loops through all chars in title above
            foreach (char c in Progressbar)
            {
                //sets the title, and makes it look like someone is typing it in
                title += c;
                Console.Title = title;
                Thread.Sleep(75);
            }
        }

        //A public method to show MainMenu
        public void MainMenu(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            //Clears Console
            MenuClear();
            //Writes out the main menu
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("                  Vending Machine");
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("1. Pick product");
            Console.WriteLine("2. Contact admin");
            Console.WriteLine("");
            
            //Calls the UserMainMenuChoice method to get the users choice
            UserMainMenuChoice(products, moneyBox);

        }

        //A public method to show MainMenu
        private void ProductMenu(Dictionary<string, Product> products)
        {
            //Clears Console
            MenuClear();
            
            //Writes out the 
            Console.WriteLine("----------**********#Products#**********----------");
            //Writes out every product in the products dictionary
            foreach (KeyValuePair<string, Product> p in products)
            {
                //Checks if the product is out of stock
                //If its in stock
                if (p.Value.Stock > 0)
                {
                    //Writes out the infomation the user needs in order to buy the product
                    Console.WriteLine(p.Key + ". " + p.Value.Name + "   Costs: " + p.Value.Cost + " Dollars");
                }
                //If its out of stock
                else
                {
                    //Writes out that the product is out of stock
                    Console.WriteLine(p.Key + ". " + p.Value.Name + "   OUT OF STOCK! Contact admin to restock the machine");
                }
            }
        }

        //A private method to show AdminMenu
        private void AdminMenu(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            //Clears Console
            MenuClear();

            //Writes out the admin menu and the choices in the menu
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("                      Admins  ");
            Console.WriteLine("----------**********##########**********----------");
            Console.WriteLine("1. Change Product");
            Console.WriteLine("2. Restock Products");
            Console.WriteLine("3. Empty Money Box");
            Console.WriteLine("");

            //Calls AdminMenuChoice to ask for the user choice
            AdminMenuChoice(products,moneyBox);
        }

        //A private method to Get the users Main menu Choice
        private void UserMainMenuChoice(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            //ask user to write a number
            Console.WriteLine("Choose your number");
            choice = Console.ReadKey();

            //Switch to check what key the user pressed and what to do when that key is pressed
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    //Calls the ProductMenu method
                    ProductMenu(products);

                    //Calls the UserProductMenuChoice method
                    UserProductMenuChoice(products, moneyBox);
                    break;
                case ConsoleKey.D2:
                    //Calls the AdminLogin method
                    AdminLogin(products, moneyBox);
                    break;
                default:
                    //If the user pressed any other key then the ones above then the programs types Error and gives the user a chance again
                    Console.WriteLine("");
                    Console.WriteLine("Error");
                    Thread.Sleep(200);
                    break;
            }
        }

        //A private method to Get the users Product menu choice
        private void UserProductMenuChoice(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            //Asks user to insert money and saves it in a int
            Console.WriteLine("Insert money");
            int money = int.Parse(Console.ReadLine());

            //Calls the moneyBox objekts pay Method
            moneyBox.Pay(money);

            //Ask user to select the product they want to buy
            Console.WriteLine("Select the product you want to buy");
            dictionaryKeyChoice = Console.ReadLine();

            //Checks and runs the moneyBox objekts ReturnRestOfMoney Method
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

        //A private method to Get the users admin menu choice
        private void AdminMenuChoice(Dictionary<string, Product> products, MoneyBox moneyBox)
        {
            //asks for the users choice
            Console.Write("Choose a number: ");
            choice = Console.ReadKey();

            //checks the key the user pressed
            switch (choice.Key)
            {
                //if key 1 is pressed
                case ConsoleKey.D1:
                    //Clears Console
                    MenuClear();

                    //Calls the ChangeProduct method
                    ChangeProduct(products);
                    break;
                //if key 2 is pressed
                case ConsoleKey.D2:
                    //Clears Console
                    MenuClear();

                    //Calls the Restock Method
                    Restock(products);
                    break;
                //if key 3 is pressed
                case ConsoleKey.D3:
                    //Clears Console
                    MenuClear();

                    //Calls the moneyBox objekts method called EmptyMoneyBox
                    moneyBox.EmptyMoneyBox();
                    break;
                //if none of the above is pressed
                default:
                    //Clears Console
                    MenuClear();
                    break;
            }
        }

        //A private method to Get the user to login as admin, to allow the user to access the admin menu
        private void AdminLogin(Dictionary<string, Product> products,MoneyBox moneyBox)
        {
            //Clears Console
            MenuClear();
            Console.WriteLine("Admin contacted");
            Thread.Sleep(2000);

            //Asks the user to input the admin code
            Console.WriteLine("Type Login code");
            string code = Console.ReadLine();

            //If code is Correct
            if (code == "AdminPassword")
            {
                //Calls AdminMenu method
                AdminMenu(products,moneyBox);
            }
        }

        //A private method to Let the user as admin change a product
        private void ChangeProduct(Dictionary<string, Product> products)
        {
            //Writes out the all products dictionary keys and product names
            foreach (KeyValuePair<string, Product> p in products)
            {
                Console.Write(p.Key + " " + p.Value.Name + " /  ");
            }

            //Asks admin what product they want to change
            Console.WriteLine("");
            Console.WriteLine("Write the key to the product you want to change");
            string dictionaryKey = Console.ReadLine();

            //Asks admin for the new products name
            Console.WriteLine("Write the name of the new Product");
            string newName = Console.ReadLine();

            //Asks admin for the new products cost
            Console.WriteLine("Write the cost of the product");
            int newCost = int.Parse(Console.ReadLine());

            //Asks admin for the new products stock amount
            Console.WriteLine("Write stock amount");
            int newStock = int.Parse(Console.ReadLine());

            //Loops throgh dictionary to find the product to admin want to change
            foreach (KeyValuePair<string, Product> p in products)
            {
                //Checks if its the product the admin wants to change
                if (p.Key == dictionaryKey)
                {
                    //Changes the Properties of the product
                    p.Value.Name = newName;
                    p.Value.Cost = newCost;
                    p.Value.Stock = newStock;
                    p.Value.MaxStock = newStock;
                }
            }
        }

        //A private method to Let the user as admin restock the products
        private void Restock(Dictionary<string, Product> products)
        {
            //Resets all products stock amount to thier max stock amount
            Console.WriteLine("Restocking all products...");
            Thread.Sleep(4000);
            //Foreach loop to restock all products
            foreach (KeyValuePair<string, Product> p in products)
            {
                p.Value.Stock = p.Value.MaxStock;
            }
            Console.WriteLine("restocking done");
            Thread.Sleep(2000);
        }

        //Private method to clear the Console Window
        private void MenuClear()
        {
            //Clears the Console window
            Console.Clear();
        }
    }
}
