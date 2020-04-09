using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class WebPage:IWebPage
    {
        private string html = "html";
        private string css = "css";
        private string js = "js";
        public void display()
        {
            Console.WriteLine( $"{html} {css} {js}  webpage");
        }
    }
}
