using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class DrawerClient
    {
        List<IShape> Shapes = new List<IShape>();

        public List<IShape> GetShapes()
        {
            return Shapes;
        }

        public void AddShape(IShape shape)
        {
            Console.WriteLine($"adding {shape.GetType().Name}");
            Shapes.Add(shape);
        }

        public void Draw()
        {
            if (Shapes.Count == 0)
            {
                Console.WriteLine("Nothing to draw");
            }
            else
            {
                Shapes.ForEach(shape => shape.Draw());
            }
        }
        public void Resize()
        {
            if (Shapes.Count == 0)
            {
                Console.WriteLine("Nothing to resize");
            }
            else
            {
                Shapes.ForEach(shape => shape.Resize());
            }
        }
    }
}
