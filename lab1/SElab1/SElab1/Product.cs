using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    internal class Product
    {
        private Money productPrice;
        private string productName { get; set; }

        public string unitOfMeas { get; set; }
        public int quantity { get; set; }
        public DateTime data { get; set; }

        public Product(Money ProductPrice, string ProductName, string unitOfMeas, int quantity)
        {
            productPrice = ProductPrice;
            productName = ProductName;
            this.unitOfMeas = unitOfMeas;
            this.quantity = quantity;
            data = DateTime.Now; 

        }


        //methods
        public void Discount(int intPart, int doublePart)
        {
            intPart = productPrice.intPart - intPart;
            doublePart = productPrice.doublePart - doublePart;
            productPrice.ChangeValue(intPart, doublePart);
        }

        public string NowProductPrice()
        {
            return productPrice.ShowBalance();
        }

        public string ProductName()
        {
            return productName;
        }


    }
}
