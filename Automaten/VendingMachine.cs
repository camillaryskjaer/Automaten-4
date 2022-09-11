using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;
using Automaten.Guis;

namespace Automaten
{
    internal class VendingMachine
    {
        //A bool that decides if the program should stop or not
        private bool exit;

        //Creates a GUI objekt, MoneyBox objekt and a dictionary of string and products, with the string as keys and product as values
        GUI gui = new GUI();
        MoneyBox moneyBox = new MoneyBox();
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        //Creates some products so the vending machine has some product as it starts
        Product water = new Drink("Water", "A1", 10, 3);
        Product soda = new Drink("Soda", "A2", 15, 3);
        Product redbull = new Drink("Rebull", "A3", 20, 3);
        Product chips = new Snack("Chips", "B1", 10, 2);
        Product candy = new Snack("Candy", "B2", 15, 2);

        //Public void method thats to run the machine
        public void Run()
        {
            //Calls Gui method called title
            gui.Title();
            //Add the products to the dictionary products
            products.Add(water.DicitonaryKey, water);
            products.Add(soda.DicitonaryKey, soda);
            products.Add(redbull.DicitonaryKey, redbull);
            products.Add(chips.DicitonaryKey, chips);
            products.Add(candy.DicitonaryKey, candy);

            //Do while loop to keep the program running
            do
            {
                //Calls the gui MainMenu
                gui.MainMenu(products, moneyBox);
            } while (exit != true);
        }
    }
}
