using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Video: IConverter
    {
        public void encode()
        {
            Console.WriteLine("Video encoded!");
        }
        public void decode()
        {
            Console.WriteLine("Video decoded!");
        }
        public void convert(string toFormat)
        {
            Console.WriteLine("Video has been converted to " + toFormat);
        }
    }
}
