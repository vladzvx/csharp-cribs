using Encapsulation.Interfaces;
using Encapsulation.Services;
using Encapsulation.Services.Workers;
using Microsoft.Extensions.DependencyInjection;

namespace Encapsulation
{
    public class WorkersConfigurer
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IGenericWorkerFactory<NeuroWorker>, GenericWorkerFactory<NeuroWorker>>();
            services.AddSingleton<IGenericWorkerFactory<RandomForestWorker>, GenericWorkerFactory<RandomForestWorker>>();
            services.AddSingleton<IGenericWorkerFactory<WebWorker>, GenericWorkerFactory<WebWorker>>();

            services.AddSingleton<WorkersPool<WebWorker>>();
            services.AddSingleton<WorkersPool<RandomForestWorker>>();
            services.AddSingleton<WorkersPool<WebWorker>>();

        }
    }
}
