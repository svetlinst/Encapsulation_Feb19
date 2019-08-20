namespace PizzaCalories
{
    using PizzaCalories.Models;
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine())!="END")
            {
                var commandLine = ReadInput(input);

                try
                {
                    switch (commandLine[0].ToLower())
                    {
                        case "dough":
                            Dough dough = new Dough(commandLine[1],commandLine[2], double.Parse(commandLine[3]));
                            Console.WriteLine(dough.CaloriesPerGram);
                            break;
                        case "topping":
                            Topping topping = new Topping(commandLine[1], double.Parse(commandLine[2]));
                            Console.WriteLine(topping.CaloriesPerGram);
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }

        }

        private static string[] ReadInput(string input)
        {
            return input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
