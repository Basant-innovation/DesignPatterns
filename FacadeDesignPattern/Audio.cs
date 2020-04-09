using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Audio: IConverter
    {
        public void encode()
        {
            Console.WriteLine("Audio encoded!");
        }
        public void decode()
        {
            Console.WriteLine("Audio decoded!");
        }
        public void convert(string toFormat)
        {
            Console.WriteLine("Audio has been converted to " + toFormat);
        }
    }
}
