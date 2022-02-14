using Encapsulation.Interfaces;

namespace Encapsulation.Services
{
    public class WorkersPool<TWorker> where TWorker : IWorker, new()
    {
        public TWorker Get()
        {
            return new TWorker();
        }

        public void Put(TWorker worker)
        {
        }
    }
}
