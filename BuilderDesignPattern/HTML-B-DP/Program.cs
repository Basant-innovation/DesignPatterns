using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChildFluent("li", "first")
                .AddChildFluent("li", "second")
                .AddChildFluent("li", "third");
            Console.WriteLine(htmlBuilder);
            htmlBuilder.Clear();
            Console.WriteLine(htmlBuilder);
            Console.Read();
        }
    }
}
