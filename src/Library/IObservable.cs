namespace Observer
{
    public interface IObservable<Temperature>
    {
        void Subscribe(IObserver<Temperature> observer);

        void Unsubscribe(IObserver<Temperature> observer);
    }
}