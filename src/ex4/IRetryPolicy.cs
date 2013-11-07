using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex4
{
    public interface IRetryPolicy
    {
        int MaxRetries { get; }
    }
}
