using System;

namespace IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new FibonacciCollection();

            for (int i = 0; i < 10; i++)
            {
                collection.AddItem(i);
            }

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            Console.Read();
        }
    }
}
