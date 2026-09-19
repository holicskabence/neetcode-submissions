public class Solution {
    public bool IsSubsequence(string s, string t) {
        int left = 0;
        for(int i = 0; i < t.Length; i++)
        {
            if(s[left] == t[i])
            {
                left++;

                if(left == s.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }
}