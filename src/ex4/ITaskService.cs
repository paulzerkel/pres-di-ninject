using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex4
{
    public interface ITaskService
    {
        List<WorkTask> FindTasks(string email);
    }
}
