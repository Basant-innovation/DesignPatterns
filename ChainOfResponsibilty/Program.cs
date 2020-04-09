using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    class Program
    {
        static void Main(string[] args)
        {
            var pastaHandler = new PastaCheifHandler();
            var pizzaHandler = new PizzaCheifHandler();
            var seaFoodHandler = new SeaFoodHandler();

            pastaHandler.SetNext(pizzaHandler).SetNext(seaFoodHandler);
            Client.ClientCode(pastaHandler);
            Console.WriteLine();
        }
    }
}
