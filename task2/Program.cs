using System;
using System.Linq;

namespace task2
{
    internal static class Program
    {
        private static void Main()
        {
            var customerCollection = new CustomerCollection
            {
                new Customer("name 1", "category 1"),
                new Customer("name 1", "category 2"),
                new Customer("name 2", "category 2"),
                new Customer("name 2", "category 3")
            };
            foreach (var customer in customerCollection)
            {
                Console.WriteLine(customer.ToString());
            }

            foreach (var customer in customerCollection.Where(customer => customer.Name == "name 1"))
            {
                Console.WriteLine(customer.Category);
            }

            foreach (var customer in customerCollection.Where(customer => customer.Category == "category 2"))
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}