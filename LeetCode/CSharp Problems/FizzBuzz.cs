using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.CSharp_Problems
{
    public class FizzBuzz
    {
        public IList<string> LCFizzBuzz(int n)
        {
            List<string> listN = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 & i % 5 != 0)
                {
                    listN.Add(i.ToString());
                    continue;
                }
                if (i % 3 == 0 & i % 5 != 0)
                {
                    listN.Add("Fizz");
                    continue;
                }
                if (i % 5 == 0 & i % 3 != 0)
                {
                    listN.Add("Buzz");
                    continue;
                }
                if (i % 3 == 0 & i % 5 == 0)
                {
                    listN.Add("FizzBuzz");
                    continue;
                }
            }
            return listN;
        }
    }
}

/* Date: 26 Aug 2020
 * 
 * Fizz Buzz: https://leetcode.com/problems/fizz-buzz/
 * 
 * Write a program that outputs the string representation of numbers from 1 to n.

But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.

Example:

n = 15,

Return:
[
    "1",
    "2",
    "Fizz",
    "4",
    "Buzz",
    "Fizz",
    "7",
    "8",
    "Fizz",
    "Buzz",
    "11",
    "Fizz",
    "13",
    "14",
    "FizzBuzz"
]

*/
