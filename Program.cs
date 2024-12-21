
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int longestSubstringCount = 0;
        int longestSubstringCountInTheLoop = 0;
        List<char> substringList = new List<char>(); 

        // Return 0 if the substring = 0
        if (s.Length == 0)
        {
            return 0;
        }

        for (int i =0; i < s.Length; i++)
        {
            if (!substringList.Contains(s[i]))
            {
                substringList.Add(s[i]);
                longestSubstringCountInTheLoop ++;
            }
            else
            {
                if (longestSubstringCountInTheLoop >= longestSubstringCount)
                {
                    longestSubstringCount = longestSubstringCountInTheLoop;
                    longestSubstringCountInTheLoop = 0;
                }
                substringList.Clear();
                if (i != 0)
                {
                    i--;
                }
            }
        }       

        return longestSubstringCount;
    }

static void Main(string[]args)
{
    Solution s = new Solution();
    
    string input1 = "abcabcbb";
    Console.WriteLine(s.LengthOfLongestSubstring(input1));

    string input2 = "bbbbb";
    Console.WriteLine(s.LengthOfLongestSubstring(input2));

    string input3 = "pwwkew";
    Console.WriteLine(s.LengthOfLongestSubstring(input3));



}

}