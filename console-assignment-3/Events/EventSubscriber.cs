using System;

namespace ConsoleApp3.Subscribers
{
    internal class EventSubscriber
    {
        public void SubscriberMethod(string msg)
        {
            Console.WriteLine(msg + " The subscriber gets the event!");
        }
    }
}
