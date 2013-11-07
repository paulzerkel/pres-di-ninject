using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex5
{
    public class LoggingRetryPolicy : IRetryPolicy
    {
        private readonly IRetryPolicy retryPolicy;

        public int MaxRetries
        {
            get 
            {
                Console.WriteLine(" -- BEFORE MaxRetries --");
                var maxRetries = retryPolicy.MaxRetries;
                Console.WriteLine(" -- AFTER MaxRetries --");
                return maxRetries;
            }
        }

        public LoggingRetryPolicy(IRetryPolicy retryPolicy)
        {
            this.retryPolicy = retryPolicy;
        }
    }
}
