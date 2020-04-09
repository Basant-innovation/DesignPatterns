using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();
            Person person = personBuilder
                .Lives
                    .Street("Cairo")
                    .Postal("12345")
                .Works
                    .IsA("Developer")
                    .InA("Microsoft")
                    .Earning(10000);
            Console.WriteLine(person.ToString());
            Console.Read();
        }
    }
}
