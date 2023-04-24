using System;
using System.Collections.Generic;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] PlusOne(int[] digits)
            {
                Array.Reverse(digits);
                List<int> newList = new List<int>();
                int carry = 0;
                for(int i = 0; i < digits.Length; i++)
                {
                    int element = 0;
                    element = element + carry;
                    if (i == 0)
                    {
                        element = element+digits[i] + 1;
                    }
                    else
                    {
                        element = digits[i]+carry;
                        carry = 0;
                    }
                    if (element >= 10)
                    {
                        carry = (int)element / 10;
                        element = element % 10;
                    }
                    
                    newList.Add(element);
                }
                if (carry != 0)
                {
                    newList.Add(carry);
                }
                var d = newList.ToArray();
                Array.Reverse(d);
                return d;
            }
            int[] digits = new int[] { 1,2,9};
            Console.WriteLine(PlusOne(digits));
        }
    }
}
