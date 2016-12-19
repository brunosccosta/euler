using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem16 : IProblem
    {
        public void Run()
        {
            int result = 0;

            BigInteger number = BigInteger.Pow(2, 1000);

            while(number > 0)
            {
                result += (int) (number % 10);
                number = number / 10;
            }

            Console.WriteLine(result);
        }
    }
}
