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
        Dictionary<string, Product> products = new Dictionary<string, Product>();
        public void test()
        {
            do
            {
                gui.MenuClear();
                gui.MainMenu(products);

            } while (exit != true);

        }
    }
}
