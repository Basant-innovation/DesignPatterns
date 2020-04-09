using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("drawing Rectangle");
        }

        public void Resize()
        {
            Console.WriteLine("resizing Rectangle");
        }

        public string Description()
        {
            return "Rectangle object";
        }

        public bool IsHide()
        {
            Console.WriteLine("hiding Rectangle");
            return false;
        }
    }
}
