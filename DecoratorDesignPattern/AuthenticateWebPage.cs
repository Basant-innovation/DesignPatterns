using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class AuthenticateWebPage: WebPageDecorator
    {
        public AuthenticateWebPage(IWebPage decoratedPage): base(decoratedPage)
        {
        }

        public void authenticateUser()
        {
            Console.WriteLine("authenticating user");
        }

        public override void display()
        {
            base.display();
            this.authenticateUser();
        }
    }
}
