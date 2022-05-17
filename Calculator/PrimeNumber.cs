using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class PrimeNumber
    {   
        public int findPrimeNumber(int number)
        {
            int num = 1;
            int count = 0;
            while (true)
            {
                num++;
                if (isPrime(num))
                {
                    count++;
                }
                if (count == number)
                {
                    return num;
                }
            }
        }
        private static bool isPrime(int number)
        {
            int counter = 0;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0)
                {
                    counter = 1;
                    break;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
