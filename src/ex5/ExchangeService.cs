using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex5
{
    public class ExchangeService : ITaskService
    {
        private readonly IRetryPolicy retryPolicy;
        private readonly Uri url;

        public ExchangeService(IRetryPolicy retryPolicy, Uri url)
        {
            this.retryPolicy = retryPolicy;
            this.url = url;
        }

        public List<WorkTask> FindTasks(string email)
        {
            Console.WriteLine("Connecting to {0} to look for work tasks.", url.ToString());
            Console.WriteLine("Max retry attempts: {0}", retryPolicy.MaxRetries);
            return new List<WorkTask> { 
                new WorkTask(10, "Create demo"),
                new WorkTask(11, "Work on sprint 1"),
                new WorkTask(99, "Make coffee"),
                new WorkTask(5, "Find stapler"),
                new WorkTask(8, "clean desk")
            };
        }
    }
}
