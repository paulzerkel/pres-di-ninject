using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex1
{
    public class TaskFinder
    {
        private readonly ExchangeService service = new ExchangeService(new Uri("http://www.someserver.com"));

        public IEnumerable<WorkTask> Find(string email, int minPriority)
        {
            return service.FindTasks(email).Where(x => x.Priority >= minPriority);
        }
    }
}
