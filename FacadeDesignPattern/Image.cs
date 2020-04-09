using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Image : IConverter
    {
        public void encode()
        {
            Console.WriteLine("Image encoded!");
        }
        public void decode()
        {
            Console.WriteLine("Image decoded!");
        }
        public void convert(string toFormat)
        {
            Console.WriteLine("Image has been converted to " + toFormat);
        }
        
    }
}
