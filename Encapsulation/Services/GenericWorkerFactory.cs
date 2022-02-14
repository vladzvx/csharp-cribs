using Encapsulation.Interfaces;

namespace Encapsulation.Services
{
    public class GenericWorkerFactory<TWorker> : IGenericWorkerFactory<TWorker> where TWorker : IWorker, new()
    {
        private readonly WorkersPool<TWorker> workerPool;
        public GenericWorkerFactory(WorkersPool<TWorker> workerPool)
        {
            this.workerPool = workerPool;
        }

        public WorkerWrapper GetWorker()
        {
            WorkerWrapper workerWrapper;
            if (!WorkerWrapper.Pool.TryTake(out workerWrapper))
            {
                workerWrapper = new WorkerWrapper();
            }
            workerWrapper.workerFactory = this;
            workerWrapper.worker = workerPool.Get();
            return workerWrapper;
        }

        public void PutWorker(WorkerWrapper workerWrapper)
        {

            workerPool.Put((TWorker)workerWrapper.worker);
            workerWrapper.worker = null;
            WorkerWrapper.Pool.Add(workerWrapper);
        }
    }
}
