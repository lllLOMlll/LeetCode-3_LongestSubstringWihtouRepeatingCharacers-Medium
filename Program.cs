public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        
        if (s.Length == 0)
        {
            return 0;
        }
        
        // Longest substring counter
        // Loop through the string character
        // Build a list while looping
        // Check if the character is in the list
        // Reset the list if the character is in
        // Go back one character (I`m not sure)

        return 0;
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