using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Automaten.Products;

namespace Automaten
{
    internal class MoneyBox
    {
        //Private Variables that are used in the method in this class
        private int totalMoney;
        private int tempMoney;
        private int returnAmount;

        //Public void method that sets the tempMoney to what the user has payed
        public void Pay(int payment)
        {
            this.tempMoney = payment;
        }

        //public string method called ReturnRestOfMoney
        public string ReturnRestOfMoney(Product product)
        {
            //Checks for the product's stock to check if the user can buy one
            if (product.Stock > 0)
            {
                //Checks if the user put enough money in the machine
                //not enough money
                if (product.Cost > tempMoney)
                {
                    //Returns a string
                    return "You did not input enough money for that product\r\nYour money has been refunded, try again ;)";
                }
                //Too much money
                else if (product.Cost < tempMoney)
                {
                    //set the amount the user has to get back
                    returnAmount = tempMoney - product.Cost;

                    //puts the amount the product cost in the totalmoney int
                    this.totalMoney += product.Cost;

                    //Removes one from the product's stock
                    product.Stock--;

                    //Returns a string
                    return $"Your {product.Name} is ready to be taken, look down\r\nYou get {returnAmount} dollars back";
                }
                //Right Amount of money
                else
                {
                    //puts the amount the product cost in the totalmoney int
                    this.totalMoney += product.Cost;

                    //Removes one from the product's stock
                    product.Stock--;

                    //Returns a string
                    return $"Your {product.Name} is ready to be taken, look down\r\nYou did math and payed the right amount";
                }
            }
            //Product is out of stock
            else
            {
                //Returns a string
                return "This product is out of stock";
            }
        }

        //a public void method called EmptyMoneyBox
        public void EmptyMoneyBox()
        {
            //Emptys the totalMoney int
            Console.WriteLine($"You empty the money box, theres {totalMoney} dollars in the box");
            this.totalMoney = 0;
            Thread.Sleep(2000);
        }
    }
}
