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
        private bool exit;
        GUI gui = new GUI();
        MoneyBox moneyBox = new MoneyBox();
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        Product water = new Drink("Water", "A1", 10, 3);
        Product soda = new Drink("Soda", "A2", 15, 3);
        Product redbull = new Drink("Rebull", "A3", 20, 3);
        Product chips = new Snack("Chips", "B1", 10, 2);
        Product candy = new Snack("Candy", "B2", 15, 2);


        public void test()
        {
            gui.Title();
            products.Add(water.DicitonaryKey, water);
            products.Add(soda.DicitonaryKey, soda);
            products.Add(redbull.DicitonaryKey, redbull);
            products.Add(chips.DicitonaryKey, chips);
            products.Add(candy.DicitonaryKey, candy);
            do
            {
                gui.MainMenu(products, moneyBox);

            } while (exit != true);


        }
        public void ChangeProduct(Dictionary<string, Product> products, string dictionaryKey, string newName, int newCost)
        {
            foreach (KeyValuePair<string, Product> p in products)
            {
                if (p.Key == dictionaryKey)
                {
                    p.Value.Name = newName;
                    p.Value.Cost = newCost;
                }
            }
        }
    }
}
