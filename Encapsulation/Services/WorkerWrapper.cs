using Encapsulation.Interfaces;
using Encapsulation.Models;
using System;
using System.Collections.Concurrent;

namespace Encapsulation.Services
{
    public class WorkerWrapper : IDisposable
    {
        public IWorkerFactory workerFactory;
        public IWorker worker { get; internal set; }

        public void Dispose()
        {
            workerFactory.PutWorker(this);
        }

        public void Execute(Data data)
        {
            worker.Work(data);
        }

        internal static ConcurrentBag<WorkerWrapper> Pool = new ConcurrentBag<WorkerWrapper>();
    }
}
