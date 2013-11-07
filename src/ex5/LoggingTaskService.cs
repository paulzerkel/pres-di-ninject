using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex5
{
    public class LoggingTaskService : ITaskService
    {
        private readonly ITaskService taskService;

        public LoggingTaskService(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        public System.Collections.Generic.List<WorkTask> FindTasks(string email)
        {
            Console.WriteLine(" -- BEFORE FindTasks --");
            var tasks = taskService.FindTasks(email);
            Console.WriteLine(" -- AFTER FindTasks --");
            return tasks;
        }
    }
}
