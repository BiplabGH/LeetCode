using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Pascal_Number
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] myList = new int[rowIndex+1];
            int prev = 1;
            myList[0]=prev;
            for (int i = 1; i <= rowIndex; i++)
            {

                // nCr = (nCr-1 * (n - r + 1))/r 
                int curr = (prev * (rowIndex - i + 1)) / i;
                myList[i]=curr;
                prev = curr;
            }
            return myList;
        }
    }
}

/*
 * Date: 14 Aug 2020
 * 119. Pascal's Triangle II: https://leetcode.com/problems/pascals-triangle-ii/
 * 
 * Given an integer rowIndex, return the rowIndexth row of the Pascal's triangle.

Notice that the row index starts from 0.


In Pascal's triangle, each number is the sum of the two numbers directly above it.

Follow up:

Could you optimize your algorithm to use only O(k) extra space?

 

Example 1:

Input: rowIndex = 3
Output: [1,3,3,1]
Example 2:

Input: rowIndex = 0
Output: [1]
Example 3:

Input: rowIndex = 1
Output: [1,1]
 

Constraints:

0 <= rowIndex <= 40
*/
