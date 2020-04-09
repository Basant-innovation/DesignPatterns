using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawerClient drawer = new DrawerClient();
            drawer.AddShape(new Circle());
            drawer.AddShape(new Rectangle());
            var shape = new GeometricShapeObjectAdapter(new Triangle());
            drawer.AddShape(shape);
            drawer.Draw();
            drawer.Resize();
            Console.Read();
        }
    }
}
