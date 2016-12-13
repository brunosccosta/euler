using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem5 : IProblem
    {
        public void Run()
        {
            var number = 20;

            while(!IsTheRightNumber(number))
            {
                number += 20;
            }

            Console.WriteLine(number);
        }

        private bool IsTheRightNumber(int n)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (n % i != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
