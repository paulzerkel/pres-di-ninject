using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex4
{
    public class TaskFinder
    {
        private readonly ITaskService service;

        public TaskFinder(ITaskService service)
        {
            this.service = service;
        }

        public IEnumerable<WorkTask> Find(string email, int minPriority)
        {
            return service.FindTasks(email).Where(x => x.Priority >= minPriority);
        }
    }
}
