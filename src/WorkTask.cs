using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    public class WorkTask
    {
        public int Priority { get; set; }

        public string Name { get; set; }

        public WorkTask()
        {

        }

        public WorkTask(int priority, string name)
        {
            Priority = priority;
            Name = name;
        }
    }
}
