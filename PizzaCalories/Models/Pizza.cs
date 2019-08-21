using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories.Models
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public double TotalCalories
        {
            get
            {
                var cal = this.toppings.Sum(c => c.CaloriesPerGram) + this.dough.CaloriesPerGram;
                return cal;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length<1 || value.Length >15 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public List<Topping> Toppings
        {
            get => this.toppings;
            private set
            {
                if (value.Count<0 || value.Count>20)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppings = value;
            }
        }

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count<10)
            {
                this.Toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public Dough Dough
        {
            get => this.dough;
            set => this.dough = value;
        }

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }
    }
}
