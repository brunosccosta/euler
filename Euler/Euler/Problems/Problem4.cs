using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem4 : IProblem
    {
        public void Run()
        {
            var largest = 0;

            var n1 = 999;
            var n2 = n1;
            while (n1 >= 100)
            {
                var product = n1 * n2;
                if (IsPalindrome(product))
                {
                    if (product > largest)
                    {
                        largest = product;
                    }
                }

                if (n2 == 100)
                {
                    n1--;
                    n2 = n1;
                }
                else
                {
                    n2--;
                }
            }

            Console.WriteLine(largest);
        }

        private bool IsPalindrome(int n)
        {
            var str = n.ToString();

            var lenMinus1 = str.Length - 1;
            var lenDiv2 = str.Length / 2;

            for (int i = 0; i < lenDiv2; i++)
            {
                if (str[i] != str[lenMinus1-i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
