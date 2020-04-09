using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    //Adapter Class
    class GeometricShapeObjectAdapter: IShape
    {
        private IGeometricShape adaptee;

        public GeometricShapeObjectAdapter(IGeometricShape shape)
        {
            adaptee = shape;
        }
        public void Draw()
        {
            adaptee.DrawShape();
        }

        public void Resize()
        {
            Console.WriteLine($"{Description()} can't be resized. Please create new one with required values");
        }

        public string Description()
        {
            return adaptee.GetType().Name + " object";
        }

        public bool IsHide()
        {
            return false;
        }
    }
}
