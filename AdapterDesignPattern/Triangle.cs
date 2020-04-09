using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Triangle: IGeometricShape
    {
        public double Side { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle() : this(1.0d, 1.0d, 1.0d)
        {

        }
        public Triangle(double side, double triangleBase, double height)
        {
            Side = side;
            Base = triangleBase;
            Height = height;
        }
        public double Area()
        {
            double area = (Side + Height + Base) / 2;
            return Math.Sqrt(area * (area - Side) * (area - Base) * (area - Height));
        }

        public double Perimeter()
        {
            return Side + Height + Base;
        }

        public void DrawShape()
        {
            Console.WriteLine($"Drawing {this.GetType().Name} with: Area: {Area()} and Perimeter: {Perimeter()}");
        }
    }
}
