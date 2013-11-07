using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex3
{
    public class Example3Module : NinjectModule
    {
        public override void Load()
        {
            Bind<ITaskService>().To<ExchangeService>().WithConstructorArgument("url",
                new Uri("http://anotherserver.com"));
        }
    }
}
