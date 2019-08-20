using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                money = value;
            }
        }

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<Product>();
        }

        public void BuyProduct(Product product)
        {
            if (CanAffordProduct(product))
            {
                this.money -= product.Cost;
                bagOfProducts.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        private bool CanAffordProduct(Product product)
        {
            if (product.Cost<=this.Money)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetProducts()
        {
            StringBuilder sb = new StringBuilder($"{this.Name} - ");
            if (bagOfProducts.Count == 0)
            {
                sb.Append("Nothing bought");
            }
            else
            {
                sb.Append(string.Join(", ", bagOfProducts));
            }
            return sb.ToString();
        }
    }
}
