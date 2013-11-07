using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex1
{
    public class ExchangeService
    {
        private readonly Uri url;

        public ExchangeService(Uri url)
        {
            this.url = url;
        }

        public List<WorkTask> FindTasks(string email)
        {
            Console.WriteLine("Connecting to {0} to look for work tasks.", url.ToString());
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
