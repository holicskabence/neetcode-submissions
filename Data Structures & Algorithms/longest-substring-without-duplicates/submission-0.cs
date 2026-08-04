public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int maxLength = 1;
        string current = string.Empty;

        for(int i = 0; i < s.Length; i++){
            int index = current.IndexOf(s[i]);
            current += s[i];
            if(index != -1)
            {
                int currentLength = current.Length - 1;
                if(maxLength < currentLength)
                {
                    maxLength = currentLength;
                }

                left = left + index;
                current = s.Substring(left, current.Length - index - 1);
            }
        }

        return maxLength;
    }
}
