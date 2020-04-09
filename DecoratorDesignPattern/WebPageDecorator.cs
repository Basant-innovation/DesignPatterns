using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    abstract class WebPageDecorator: IWebPage
    {
        IWebPage page;
        public WebPageDecorator(IWebPage webPage)
        {
            this.page = webPage;
        }
        public virtual void display()
        {
            this.page.display();
        }
    }
}
