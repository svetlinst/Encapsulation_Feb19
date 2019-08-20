namespace PizzaCalories
{
    using PizzaCalories.Models;
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaName = ReadInput(Console.ReadLine());
                Pizza pizza = new Pizza(pizzaName[1]);
                var doughInfo = ReadInput(Console.ReadLine());
                Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
                pizza.Dough = dough;
                string input;

                while ((input = Console.ReadLine()) != "END")
                {
                    var parseCommand = ReadInput(input);
                    Topping topping = new Topping(parseCommand[1], double.Parse(parseCommand[2]));
                    pizza.AddTopping(topping);

                }
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private static string[] ReadInput(string input)
        {
            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
