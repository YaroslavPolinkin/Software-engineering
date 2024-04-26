using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class Reporting
    {
        private Warehouse inventory;

        public Reporting(Warehouse inventory)
        {
            this.inventory = inventory;
        }

        public void AddProduct(Product product)
        {
            inventory.products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            inventory.products.Remove(product);
        }

        public string RegisterOutgoing(Product product, int quantity)
        {
            foreach(Product el in inventory.products)
            {
                if(el.ProductName == product.ProductName)
                {
                    if (el._quantity >= quantity) {
                        el._quantity -= quantity;
                        return $"кількість {product.ProductName()} тепер {el._quantity}";
                    }
                    else return $"наявна кількість {el._quantity}";

                }
            }
            return $"продукт {product.ProductName()} не знайдено";

        }

        public string GoodsReceipt(Product product, int quantity)
        {
            foreach (Product el in inventory.products)
            {
                if (el.ProductName == product.ProductName)
                {
                    el._quantity += quantity;
                    return $"кількість {product.ProductName} тепер {el._quantity}";
                }
            }
            return "помилка!";

        }

        public string GenerateInventoryReport()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product product in inventory.products)
            {
                sb.Append(product.ProductName())
                  .Append(" ")
                  .Append(product._quantity)
                  .Append(" ")
                  .Append(product._unitOfMeas)
                  .Append(" ");

            }
            return sb.ToString();

        }

    }
}
