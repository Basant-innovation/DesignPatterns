using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    class PizzaCheifHandler:Handler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "pizza")
            {
                return $"Pizza Cheif: Your order {request.ToString()} will be placed.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
