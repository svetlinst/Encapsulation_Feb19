namespace PizzaCalories.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Topping
    {
        private double weight;
        private string toppingType;

        private const double minWeight = 1;
        private const double maxWeight = 50;
        private const double baseCaloriesPerGram = 2;

        public double CaloriesPerGram
        {
            get
            {
                return baseCaloriesPerGram * weight * IngredientsUtility.GetToppingModifier(toppingType);
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public string ToppingType
        {
            get => this.toppingType;
            private set
            {
                if (!IngredientsUtility.IsToppingValid(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            }
        }

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }
    }
}
