using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    class SeaFoodHandler: Handler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "seafood")
            {
                return $"Seafood Cheif: Your order {request.ToString()} will be placed.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
