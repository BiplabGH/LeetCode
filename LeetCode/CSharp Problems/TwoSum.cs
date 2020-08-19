using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.CSharp_Problems
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] a = new int[2];
            a[0] = 0;
            a[1] = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int t = nums[i] + nums[j];
                    if (t == target)
                    {
                        a[0] = i;
                        a[1] = j;
                        return a;
                    }

                }

            }
            return a;

        }
    }
}

/*
 * Date: 10 Dec 2019
 * 
 * 1. Two Sum: https://leetcode.com/problems/two-sum/
 * 
 * Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/
