using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class AuthorizeWebPage: WebPageDecorator
    {
        public AuthorizeWebPage(IWebPage decoratedPage): base(decoratedPage)
        {
        }

        public void authorizeUser()
        {
            Console.WriteLine("authorizing user");
        }

        public override void display()
        {
            base.display();
            this.authorizeUser();
        }
    }
}
