public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var s1Chars = new Dictionary<char, int>();
        var windowChars = new Dictionary<char, int>();
        int left = 0;

        if(s1.Length > s2.Length){
            return false;
        }

        for(int i = 0; i < s1.Length; i++)
        {
            s1Chars[s1[i]] = s1Chars.GetValueOrDefault(s1[i]) + 1;

            if(i < s1.Length - 1){
                windowChars[s2[i]] = windowChars.GetValueOrDefault(s2[i]) + 1;
            }
        }

        for(int i = s1.Length - 1; i < s2.Length; i++)
        {
            windowChars[s2[i]] = windowChars.GetValueOrDefault(s2[i]) + 1;

            bool match = s1Chars.Count == windowChars.Count && !s1Chars.Except(windowChars).Any();
            if(match)
            {
                return true;
            }

            char leftChar = s2[left];

            windowChars[leftChar] = windowChars.GetValueOrDefault(leftChar) - 1;

            if (windowChars[leftChar] == 0)
            {
                windowChars.Remove(leftChar);
            }
            
            left++;
        }

        return s1Chars.Count == windowChars.Count && !s1Chars.Except(windowChars).Any();
    }
}
