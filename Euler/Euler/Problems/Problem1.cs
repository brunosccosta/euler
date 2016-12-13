using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem1 : IProblem
    {
        private const int _target = 1000;

        public void Run()
        {
            int sum = 0;

            for (int i = 0; i < _target; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
