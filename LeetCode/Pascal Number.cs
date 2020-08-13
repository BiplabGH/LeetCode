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
