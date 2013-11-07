using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which example (1 - 5)?");
            var key = Console.ReadKey(true);

            int exerciseNumber = 0;
            int.TryParse(key.KeyChar.ToString(), out exerciseNumber);

            if (exerciseNumber < 1 || exerciseNumber > 5)
            {
                Console.WriteLine("Exercise must be 1 - 5");
            }
            else
            {
                var runnerType = Type.GetType(string.Format("NinjectExample.ex{0}.Runner", exerciseNumber));
                var runner = (IRunner)Activator.CreateInstance(runnerType);
                runner.Start();

                Console.WriteLine("Complete");
                Console.ReadKey();
            }
        }
    }
}
