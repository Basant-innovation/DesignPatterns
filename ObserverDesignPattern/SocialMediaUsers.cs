using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class SocialMediaUsers: IObserver
    {
        public void update()
        {
            Console.WriteLine("Notification received");
        }
    }
}
