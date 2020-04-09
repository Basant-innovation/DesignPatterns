using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    interface IShape
    {
        void Draw();
        void Resize();
        string Description();
        bool IsHide();
    }
}
