using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConceptualExemple
{
    public class  Subject : ISubject
    {
        public int State { get; set; }
        private readonly List<IObserver> observers = [];

        public void Attach(IObserver observer)
        {
            Console.WriteLine($"Subject: Attached an observer: {observer}");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine($"Subject: Detached an observer: {observer}");
            observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine($"Subject: Notifying observers...: {GetObserversList(observers)}");

            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine($"Subject: My state has just changed to: {this.State}");
            this.Notify();
        }

        private static string GetObserversList(List<IObserver> observers)
        {
            return string.Join(", ", observers.Select(o => o.ToString()));
        }
    }
}
