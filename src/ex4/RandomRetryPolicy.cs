using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ex4
{
    public class RandomRetryPolicy : IRetryPolicy
    {
        private static Random random = new Random();

        public int MaxRetries
        {
            get { return random.Next(); }
        }
    }
}
