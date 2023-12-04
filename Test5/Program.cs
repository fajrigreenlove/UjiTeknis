using System;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new EventPublisher();

            while (true)
            {
                using (var subscriber = new EventSubscriber(publisher))
                {
                    // do something with the publisher and subscriber objects  
                }
            }
        }
    }

    class EventPublisher
    {
        public event EventHandler MyEvent;

        public void RaiseEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    class EventSubscriber : IDisposable
    {
        private EventPublisher _publisher;

        public EventSubscriber(EventPublisher publisher)
        {
            _publisher = publisher;
            _publisher.MyEvent += OnMyEvent;
        }

        private void OnMyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent raised");
        }

        public void Dispose()
        {
            if (_publisher != null)
            {
                _publisher.MyEvent -= OnMyEvent;
                _publisher = null;
            }
        }
    }
}