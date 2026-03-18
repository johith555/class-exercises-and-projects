using ConsoleApp3.Delegates;
using static ConsoleApp3.Delegates.Delegate1;

namespace ConsoleApp3.Events
{
    internal class EventPublisher
    {
        public event MyDelegate MyEvent;

        public void MyMethod(string msg)
        {
            MyEvent?.Invoke(msg);
        }
    }
}
