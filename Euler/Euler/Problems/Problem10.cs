using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem10 : IProblem
    {
        private const int _limit = 2000000;

        public void Run()
        {
            long sum = 2;
            for (int i = 3; i < _limit; i+=2)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        private bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            var limit = Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
