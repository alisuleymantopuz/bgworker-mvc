using System;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace BackgroundWorkingWithMVC.Application.BackgroudWorkers
{
    public static class BackgroundTaskRunner
    {
        public static void FireAndForgetTask(Action action)
        {
            HostingEnvironment.QueueBackgroundWorkItem(cancellationToken => // .Net 4.5.2 required
            {
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    //Log
                }
            });
        }
        public static void FireAndForgetTask(Func<Task> action)
        {
            HostingEnvironment.QueueBackgroundWorkItem(async cancellationToken => // .Net 4.5.2 required
            {
                try
                {
                    await action();
                }
                catch (Exception e)
                {
                    //Log
                }
            });
        }
    }
}