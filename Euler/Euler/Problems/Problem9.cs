using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem9 : IProblem
    {
        public void Run()
        {
            int b;
            double c;
            int a = 0;
            
            while(true)
            {
                a++;
                b = a + 1;

                c = Math.Sqrt(a * a + b * b);
                while (!IsInteger(c) || a+b+c < 1000)
                {
                    b++;
                    c = Math.Sqrt(a * a + b * b);
                }

                if (a + b + c == 1000)
                {
                    Console.WriteLine(a * b * c);
                    return;
                }
            }
        }

        private bool IsInteger(double n)
        {
            return (n % 1 == 0);
        }
    }
}
