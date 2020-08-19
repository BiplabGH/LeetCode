
using System.Linq;

namespace LeetCode.CSharp_Problems
{
    public class GoatLatin
    {
        public string ToGoatLatin(string S)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
            string vowelAdd = "ma";
            string[] arr = S.Split(" ");
            string sNew = string.Empty;
            
            for(int i=0;i<arr.Length;i++)
            {
                if(vowels.Contains(arr[i].ToLower().ToCharArray().ElementAt(0)))
                {
                    sNew += arr[i] + vowelAdd + string.Concat(Enumerable.Repeat("a", i+1)) + " ";
                }
                else
                {
                    sNew += arr[i].Substring(1, arr[i].Length-1) + arr[i].ToCharArray().ElementAt(0) + vowelAdd + string.Concat(Enumerable.Repeat("a", i+1)) + " ";
                }
            }
            return sNew.Trim();
        }
    }
}


/*
 * Date: 20 Aug 2020
 * Goat Latin: https://leetcode.com/explore/challenge/card/august-leetcoding-challenge/551/week-3-august-15th-august-21st/3429/
 * 
 A sentence S is given, composed of words separated by spaces. Each word consists of lowercase and uppercase letters only.

We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.)

The rules of Goat Latin are as follows:

If a word begins with a vowel (a, e, i, o, or u), append "ma" to the end of the word.
For example, the word 'apple' becomes 'applema'.
 
If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add "ma".
For example, the word "goat" becomes "oatgma".
 
Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
For example, the first word gets "a" added to the end, the second word gets "aa" added to the end and so on.
Return the final sentence representing the conversion from S to Goat Latin. 

Example 1:

Input: "I speak Goat Latin"
Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"
Example 2:

Input: "The quick brown fox jumped over the lazy dog"
Output: "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa"

 */
