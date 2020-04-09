using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    class PastaCheifHandler: Handler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "pasta")
            {
                return $"Pasta Cheif: Your order {request.ToString()} will be placed.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
