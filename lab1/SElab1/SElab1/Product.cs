using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class Product
    {
        private Money _productPrice;
        private string _productName;

        public string _unitOfMeas { get;  }
        public int _quantity { get; set; }
        public DateTime _creationDate { get; }

        public Product(Money ProductPrice, string ProductName, string unitOfMeas, int quantity)
        {
            _productPrice = ProductPrice;
            _productName = ProductName;
            _unitOfMeas = unitOfMeas;
            _quantity = quantity;
            _creationDate = DateTime.Now; 

        }


        //methods
        public void Discount(int intPart, int doublePart)
        {
     

            _productPrice.Subtract(intPart, doublePart);
        }

        public string NowProductPrice()
        {
            return _productPrice.ShowBalance();
        }

        public string ProductName()
        {
            return _productName;
        }


    }
}
