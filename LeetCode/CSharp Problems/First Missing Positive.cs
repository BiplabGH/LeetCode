using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.CSharp_Problems
{
    public class First_Missing_Positive
    {
        public int FirstMissingPositive(int[] nums)
        {
            int size = nums.Length;
            int shift = segregate(nums, size);

            int[] arr2 = new int[size - shift];
            int j = 0;

            for (int i = shift; i < size; i++)
            {
                arr2[j] = nums[i];
                j++;
            }
            return findMissing(arr2, j);
        }

        static int findMissing(int[] arr, int size)
        {
            int i;

            for (i = 0; i < size; i++)
            {
                if (Math.Abs(arr[i]) - 1 < size && arr[Math.Abs(arr[i]) - 1] > 0)
                    arr[Math.Abs(arr[i]) - 1] = -arr[Math.Abs(arr[i]) - 1];
            }
            for (i = 0; i < size; i++)
                if (arr[i] > 0)
                    return i + 1;
            return size + 1;
        }

        static int segregate(int[] arr, int size)
        {
            int j = 0, i;
            for (i = 0; i < size; i++)
            {
                if (arr[i] <= 0)
                {
                    int temp;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    j++;
                }
            }

            return j;
        }
    }
}

/* Date: 26 Aug 2020
 * 
 * First Missing Positive: https://leetcode.com/problems/first-missing-positive/
 * 
 * Given an unsorted integer array, find the smallest missing positive integer.

Example 1:

Input: [1,2,0]
Output: 3
Example 2:

Input: [3,4,-1,1]
Output: 2
Example 3:

Input: [7,8,9,11,12]
Output: 1
Follow up:

Your algorithm should run in O(n) time and uses constant extra space.

*/
