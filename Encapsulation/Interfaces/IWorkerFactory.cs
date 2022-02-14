using Encapsulation.Services;

namespace Encapsulation.Interfaces
{
    public interface IWorkerFactory
    {
        public WorkerWrapper GetWorker();
        public void PutWorker(WorkerWrapper workerWrapper);
    }
}
