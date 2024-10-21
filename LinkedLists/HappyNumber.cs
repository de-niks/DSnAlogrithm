using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class HappyNumber
    {
        public bool IsHappy(int n)
        {
            if (n == 1)
                return true;

            int hare = n;
            int tortoise = n;

            while (true)
            {
                hare = f(f(hare));
                tortoise = f(tortoise);

                if (hare == 1 || tortoise == 1)
                    return true;


                // cycle detected
                if(hare == tortoise)
                    return false;
            
            }

        }

        private int f(int n)
        {
            int sum = 0;

           
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

           
            return sum;

        }
    }
}
