using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebPage myPage = new WebPage();
            myPage = new AuthorizeWebPage(myPage);
            myPage = new AuthenticateWebPage(myPage);
            myPage.display();
            Console.Read();
        }
    }
}
