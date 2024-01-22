using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PrintCart()
        {
            foreach (var product in products) 
            {
                product.Display();
            }
        }
        public double CalculateTotalPrice()
        {
            double summa = 0;
            foreach (var product in products)
            {
                summa += product.Price * product.Count;
            }
            return summa;
        }
    }
}
