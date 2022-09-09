using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;

namespace Automaten
{
    internal class MoneyBox
    {
        private int totalMoney;
        private int tempMoney;
        private int returnAmount;

        public void Pay(int payment)
        {
            this.tempMoney = payment;
        }
        public string ReturnRestOfMoney(Product product)
        {
            if (product.Cost > tempMoney)
            {
                return "You did not input enough money for that product\r\nYour money has been refunded, try again ;)";
            }
            else if (product.Cost < tempMoney)
            {
                returnAmount = tempMoney - product.Cost;
                this.totalMoney += product.Cost;
                return $"Your {product.Name} is ready to be taken, look down\r\nYou get {returnAmount} dollars back";
            }
            else
            {
                this.totalMoney += product.Cost;
                return $"Your {product.Name} is ready to be taken, look down\r\nYou did math and payed the right amount";
            }
        }
    }
}
