namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            foreach (var line in input)
            {
                var tokens = line.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var money = decimal.Parse(tokens[1]);
                try
                {
                    Person curPerson = new Person(name, money);
                    persons.Add(curPerson);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    Environment.Exit(0);
                }
            }

            input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in input)
            {
                var tokens = line.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var cost = decimal.Parse(tokens[1]);
                try
                {
                    Product curProduct = new Product(name, cost);
                    products.Add(curProduct);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                    throw;
                }
            }

            string commands;
            while ((commands = Console.ReadLine())!= "END")
            {
                var tokens = commands.Split();
                var personName = tokens[0];
                var productName = tokens[1];
                persons.Where(n => n.Name == personName)
                    .FirstOrDefault()
                    .BuyProduct(products.Where(n => n.Name == productName).FirstOrDefault());
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.GetProducts());
            }
        }

    }
}
