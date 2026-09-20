public class Solution {
    public int FirstUniqChar(string s) {
        var chars = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(chars.ContainsKey(s[i]))
            {
                chars[s[i]]++;
            }
            else
            {
                chars[s[i]] = 1;
            }
        }

        for(int i = 0; i < s.Length; i++)
        {
            if(chars[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}