using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace task4
{
    class MyComparer<T> : Comparer<T>
    {
        public override int Compare(T x, T y)
        {
            return y.GetHashCode() - x.GetHashCode();
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            //Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений ключей.
            var collection = new OrderedDictionary {{"1", "a"}, {"2", "b"}};
            var list = new List<int>()
                {
                    1, 2, 3
                }
                ;

            var comparer = new MyComparer<int>();
            list.Sort(comparer);
        }
    }
}