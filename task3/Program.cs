using System;
using System.Collections;
using System.Collections.Specialized;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            //Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и вещественные значения,
            //по типу «счет предприятия – доступная сумма» соответственно.
            var accounts = new Hashtable {{100, 10.10}, {101, 20.20}, {103, 30.30}};
            foreach (var account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

            Console.WriteLine(accounts[100]);

            var accounts2 = new SortedList {{100, 10.1}, {200, 20.2}};
            foreach (DictionaryEntry account in accounts2)
            {
                Console.WriteLine(account.Key + ":" + account.Value);
            }

            var accounts3 = new ListDictionary {{100, 10.1}, {200, 20.2}};
            Console.WriteLine(accounts3);
            var accounts4 = new HybridDictionary {["100"] = 10.1};
            Console.WriteLine(accounts4);
            var accounts5 = new OrderedDictionary {{100, 10.1}, {200, 20.2}};
            Console.WriteLine(accounts5);
        }
    }
}