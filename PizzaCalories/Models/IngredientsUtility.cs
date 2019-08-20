using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Models
{
    public static class IngredientsUtility
    {
        private static Dictionary<string, double> doughModifiers = new Dictionary<string, double>
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 },
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

        private static Dictionary<string, double> toppingModifiers = new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        public static bool IsIngredientValid(string ingredient)
        {
            if (doughModifiers.ContainsKey(ingredient.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static double GetDoughModifier(string ingredient)
        {
            return doughModifiers[ingredient.ToLower()];
        }

        public static bool IsToppingValid(string toppingType)
        {
            if (toppingModifiers.ContainsKey(toppingType.ToLower()))
            {
                return true;
            }
            return false;
        }

        public static double GetToppingModifier(string topping)
        {
            return toppingModifiers[topping.ToLower()];
        }
    }
}
