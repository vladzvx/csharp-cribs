namespace Encapsulation.Interfaces
{
    public interface IGenericWorkerFactory<TWorker> : IWorkerFactory where TWorker : IWorker
    {

    }
}
