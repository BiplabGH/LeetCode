using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Excel_Sheet_Column_Number
    {

        public int TitleToNumber(string s)
        {

            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                res = res * 26 + (s[i] - 'A' + 1);

            }
            return res;
        }

    }
}

/*
 * 
 * Date: 11 Aug 2020
 * 
 * 171. Excel Sheet Column Number: https://leetcode.com/problems/excel-sheet-column-number/
 * 
 Given a column title as appear in an Excel sheet, return its corresponding column number.

For example: 

A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 

Constraints:

1 <= s.length <= 7
s consists only of uppercase English letters.
s is between "A" and "FXSHRXW".

*/
