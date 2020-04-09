using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    class Client
    {
        public static void ClientCode(Handler handler)
        {
            var request = "";
            Console.WriteLine("Welcome To Our Restuarant :)\nKindly choose your favorite dish from { Our Menu } or enter exit. \n");
            while (request != "exit") { 
                Console.WriteLine("{ Menu } => \nPasta - Pizza - Seafood");
                request = Console.ReadLine();
                var result = handler.Handle(request.ToLower());
                if (result != null)
                {
                    Console.WriteLine($"   {result}\n");
                }
                else if(request != "exit")
                {
                    Console.WriteLine($"   {request} cheif  is not available");
                }
            }

            Console.WriteLine("Thank you for visiting our Resturant. See you Soon!");
            Console.Read();
        }
    }
}
