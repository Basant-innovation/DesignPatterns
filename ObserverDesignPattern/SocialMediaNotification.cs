using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class SocialMediaNotification: ISubject
    {

        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            Console.WriteLine("A user subscribe to receive notifications");
            this._observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("A user unsubscribe to receive notifications");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Notifications:");
            foreach (var observer in _observers)
            {
                observer.update();
            }
        }

    }
}
