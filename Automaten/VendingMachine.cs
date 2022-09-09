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
        public Dictionary<string, Product> products = new Dictionary<string, Product>();
        
        Product water = new Drink("Water", "A1", 10);
        Product soda = new Drink("Soda", "A2", 15);
        Product redbull = new Drink("Rebull", "A3", 20);
        Product chips = new Snack("Chips", "B1", 10);
        Product candy = new Snack("Candy", "B2", 15);
        Product 

        public void test()
        {
            products.Add(water.DicitonaryKey, water);
            products.Add(soda.DicitonaryKey, soda);
            products.Add(redbull.DicitonaryKey, redbull);
            do
            {
                gui.MainMenu(products);

            } while (exit != true);

        }
    }
}
