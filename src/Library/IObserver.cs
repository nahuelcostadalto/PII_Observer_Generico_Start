namespace Observer
{
    public interface IObserver<Temperature>
    {
        void Update(Temperature value);
    }
}