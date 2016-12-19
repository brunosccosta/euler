using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    class Problem17 : IProblem
    {
        private Dictionary<int, string> _numbers = new Dictionary<int, string>();

        public void Run()
        {
            _numbers[1] = "one";
            _numbers[2] = "two";
            _numbers[3] = "three";
            _numbers[4] = "four";
            _numbers[5] = "five";
            _numbers[6] = "six";
            _numbers[7] = "seven";
            _numbers[8] = "eight";
            _numbers[9] = "nine";
            _numbers[10] = "ten";
            _numbers[11] = "eleven";
            _numbers[12] = "twelve";
            _numbers[13] = "thirteen";
            _numbers[14] = "fourteen";
            _numbers[15] = "fifteen";
            _numbers[16] = "sixteen";
            _numbers[17] = "seventeen";
            _numbers[18] = "eighteen";
            _numbers[19] = "nineteen";
            _numbers[20] = "twenty";
            _numbers[30] = "thirty";
            _numbers[40] = "forty";
            _numbers[50] = "fifty";
            _numbers[60] = "sixty";
            _numbers[70] = "seventy";
            _numbers[80] = "eighty";
            _numbers[90] = "ninety";

            long totalLetters = 0;
            for (int i = 1; i <= 1000; i++)
            {
                totalLetters += WriteNumber(i).Trim().Replace(" ", "").Replace("-", "").Count();
            }

            Console.WriteLine(totalLetters);
        }

        string WriteNumber(int n)
        {
            if (n == 1000)
            {
                return "One thousand";
            }

            StringBuilder stringBuilder = new StringBuilder();
            bool needsAnd = false;

            var hundreds = n / 100;
            if (hundreds > 0)
            {
                stringBuilder.Append(_numbers[hundreds]);
                stringBuilder.Append(" hundred");
                needsAnd = true;
            }

            n = n % 100;

            if (n == 0)
            {
                return stringBuilder.ToString();
            }

            var dec = n / 10;
            var unit = n % 10;

            if (needsAnd)
            {
                stringBuilder.Append(" and ");
            }

            if (dec < 2)
            {
                stringBuilder.Append(_numbers[n]);
            }
            else
            {
                stringBuilder.Append(_numbers[dec * 10]);
                if (unit > 0)
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(_numbers[unit]);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
