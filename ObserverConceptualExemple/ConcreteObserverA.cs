using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConceptualExemple
{
    internal class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (IsStateLessThanThree(subject))
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }

            static bool IsStateLessThanThree(ISubject subject)
            {
                return ((Subject)subject).State < 3;
            }
        }
    }
}
