using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class Warehouse
    {
        public List<Product> products { get; set; }


        public Warehouse(Product product)
        {
            this.products = new List<Product>();
            products.Add(product);

        }


        public string DisplayProductInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product product in products)
            {
                sb.Append(product.ProductName())
                  .Append(" ")
                  .Append(product.NowProductPrice())
                  .Append(" ")
                  .Append(product._quantity)
                  .Append(" ")
                  .Append(product._unitOfMeas)
                  .Append(" ")
                  .Append(product._creationDate)
                  .Append(" ");
            }
            return sb.ToString();
        }
    }
}
