using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialMediaNotification SMNotification = new SocialMediaNotification();
            SocialMediaUsers user1 = new SocialMediaUsers();
            SocialMediaUsers user2 = new SocialMediaUsers();

            // Adding two users to the recieve notification
            SMNotification.Subscribe(user1);
            SMNotification.Subscribe(user2);

            // Notifying users (observers)
            SMNotification.Notify();

            // A user has decided not to recieve notifications
            SMNotification.Unsubscribe(user1);

            // Notifying the updated list of users
           SMNotification.Notify();
            Console.Read();
        }
    }
}
