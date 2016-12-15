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
            var crivesize = _limit / 2;

            var crive = new bool[crivesize];
            for (int i = 0; i < crivesize; i++)
            {
                crive[i] = true;
            }

            var crivelimit = Math.Floor(Math.Sqrt(_limit));
            for (int i = 0; i < crivelimit; i++)
            {
                if (crive[i] == true)
                {
                    var n = 3 + 2 * i;
                    for (int j = i+n; j < crivesize; j+=n)
                    {
                        crive[j] = false;
                    }
                }
            }

            long sum = 2;
            for (int i = 0; i < crivesize; i++)
            {
                if (crive[i] == true)
                {
                    sum += 3 + 2 * i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
