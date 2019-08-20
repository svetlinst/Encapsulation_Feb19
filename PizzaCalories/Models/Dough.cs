using System;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private double weight;
        private string flourType;
        private string bakingTechnique;

        private const double baseCalories = 2;
        private const double minWeight = 1;
        private const double maxWeight = 200;

        public double CaloriesPerGram
        {
            get
            {
                return weight * baseCalories
                    * IngredientsUtility.GetDoughModifier(flourType) 
                    * IngredientsUtility.GetDoughModifier(bakingTechnique);       
            }
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (weight<minWeight && weight >maxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (!IngredientsUtility.IsIngredientValid(value))
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (!IngredientsUtility.IsIngredientValid(value))
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public Dough(string flour, string baking, double weight)
        {
            this.FlourType = flour;
            this.BakingTechnique = baking;
            this.Weight = weight;
        }
    }
}
