using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Circle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("drawing circle");
        }

        public void Resize()
        {
            Console.WriteLine("resizing circle");
        }

        public string Description()
        {
            return "circle object";
        }

        public bool IsHide()
        {
            Console.WriteLine("hiding circle");
            return false;
        }
    }
}
