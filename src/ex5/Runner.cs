using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex5
{
    public class Runner : IRunner
    {
        public void Start()
        {
            Console.WriteLine("Running Example 5");

            var kernel = new StandardKernel(new Example5Module());
            var taskFinder = kernel.Get<TaskFinder>();
            var tasks = taskFinder.Find("fake@example.com", 10);

            foreach (var task in tasks)
            {
                Console.WriteLine("task: {0} - priority: {1}", task.Name, task.Priority);
            }
        }
    }
}
