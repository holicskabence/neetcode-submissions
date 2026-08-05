public class Solution {
    public string MinWindow(string s, string t) {
        var need = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();
        string result = string.Empty;
        int left = 0;
        
        foreach(var c in t){
            need[c] = need.GetValueOrDefault(c) + 1;
        }

        for(int right = 0; right < s.Length; right++){
            char c = s[right];

            if(window.Count == 0)
            {
                if(need.ContainsKey(c))
                {
                    window[c] = window.GetValueOrDefault(c) + 1;
                    left = right;
                }
            }
            else if(need.ContainsKey(c))
            {
                window[c] = window.GetValueOrDefault(c) + 1;
                bool same = need.Count == window.Count && need.All(x => window.ContainsKey(x.Key) && window[x.Key] == x.Value);
                if(same){
                    if(string.IsNullOrEmpty(result) || result.Length - 1 >= right - left){
                        result = s.Substring(left, right - left + 1);
                    }

                    window.Remove(s[left]);
                    left++;

                    while(!window.ContainsKey(s[left])){
                        left++;
                    }
                }
            }
        }

        return result;
    }
}
