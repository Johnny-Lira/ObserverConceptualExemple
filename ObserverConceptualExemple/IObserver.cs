namespace ObserverConceptualExemple
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}