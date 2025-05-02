using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverConceptualExemple
{
    internal class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (IsStateZeroOrAboveTwo(subject))
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }

            static bool IsStateZeroOrAboveTwo(ISubject subject)
            {
                return ((Subject)subject).State == 0 || ((Subject)subject).State >= 2;
            }
        }
    }
}
