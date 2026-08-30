public class Solution {
    public string MinWindow(string s, string t) {
        var chars = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();
        int left = 0;
        int have = 0;
        int need = 0;
        int minStart = 0;
        int minLength = 0;

        if(s.Length < t.Length)
        {
            return string.Empty;
        }

        foreach(char c in t)
        {
            if(chars.ContainsKey(c)){
                chars[c]++;
            }else{
                chars[c] = 1;
                window[c] = 0;
                need++;
            }
        }

        for(int i = 0; i < s.Length; i++)
        {
            char current = s[i];
            if(chars.ContainsKey(current))
            {
                window[current]++;
                if(window[current] == chars[current])
                {
                    have++;
                }
            }

            while(have == need)
            {
                if(i - left < minLength - 1 || minLength == 0)
                {
                    minStart = left;
                    minLength = i - left + 1;
                }

                char leftChar = s[left];
                if(window.ContainsKey(leftChar))
                {
                    window[leftChar]--;

                    if(window[leftChar] < chars[leftChar])
                    {
                        have--;
                    }
                }

                left++;
            }
        }

        return s.Substring(minStart, minLength);
    }
}
