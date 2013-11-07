﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex4
{
    public class Runner : IRunner
    {
        public void Start()
        {
            Console.WriteLine("Running Example 4");

            var kernel = new StandardKernel(new Example4Module());
            var taskFinder = kernel.Get<TaskFinder>();
            var tasks = taskFinder.Find("fake@example.com", 10);

            foreach (var task in tasks)
            {
                Console.WriteLine("task: {0} - priority: {1}", task.Name, task.Priority);
            }
        }
    }
}
