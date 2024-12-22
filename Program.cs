
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int longestSubstringCount = 0;
        int longestSubstringCountInTheLoop = 0;
        List<char> substringList = new List<char>();
        int startIndex = 0;  // Ajout d'un index de départ

        if (s.Length == 0)
        {
            return 0;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (!substringList.Contains(s[i]))
            {
                substringList.Add(s[i]);
                longestSubstringCountInTheLoop++;
            }
            else
            {
                if (longestSubstringCountInTheLoop > longestSubstringCount)
                {
                    longestSubstringCount = longestSubstringCountInTheLoop;
                }
                // Au lieu de repartir du même i, on repart après le premier doublon
                i = startIndex + 1;
                startIndex = i;
                substringList.Clear();
                substringList.Add(s[i]);
                longestSubstringCountInTheLoop = 1;
            }
        }

        return Math.Max(longestSubstringCount, longestSubstringCountInTheLoop);
    }


    static void Main(string[] args)
    {
        Solution s = new Solution();

        string input1 = "abcabcbb";
        Console.WriteLine("3 = " + s.LengthOfLongestSubstring(input1));

        string input2 = "bbbbb";
        Console.WriteLine("1 = " + s.LengthOfLongestSubstring(input2));

        string input3 = "pwwkew";
        Console.WriteLine("3 = " + s.LengthOfLongestSubstring(input3));

        string input4 = " ";
        Console.WriteLine("1 = " + s.LengthOfLongestSubstring(input4));

        string input5 = "dvdf";
        Console.WriteLine("3 = " + s.LengthOfLongestSubstring(input5));

        string input6 = "aab";
        Console.WriteLine("2 = " + s.LengthOfLongestSubstring(input6));

    }

}