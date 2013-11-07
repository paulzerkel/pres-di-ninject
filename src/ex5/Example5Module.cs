using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex5
{
    public class Example5Module : NinjectModule
    {
        public override void Load()
        {
            Bind<ITaskService>().To<LoggingTaskService>();
            Bind<ITaskService>().To<ExchangeService>().WhenInjectedInto<LoggingTaskService>()
                .WithConstructorArgument("url", new Uri("http://anotherserver.com"));

            // Use a constraint to determine which what to bind to IRetryPolicy
            Bind<IRetryPolicy>().To<RandomRetryPolicy>().WhenInjectedInto<LoggingRetryPolicy>();
            Bind<IRetryPolicy>().To<LoggingRetryPolicy>();
        }
    }
}
