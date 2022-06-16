using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = -10;

            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("{0} was skipped", i);
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine(i++);
                }
            }
            Console.ReadLine();
        }
    }
}
