using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Quartz;

namespace Host
{
    /// <summary>
    /// Quartz���񣬳����������Զ�����Quartz����
    /// </summary>
    public class QuartzSchedulerService : IHostedService
    {
        private readonly IScheduler scheduler;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scheduler"></param>
        public QuartzSchedulerService(IScheduler scheduler)
        {
            this.scheduler = scheduler;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await scheduler.Start(cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return scheduler.Shutdown(cancellationToken);
        }
    }
}