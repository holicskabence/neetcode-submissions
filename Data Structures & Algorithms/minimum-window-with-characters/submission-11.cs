public class Solution {
    public string MinWindow(string s, string t) {
        var chars = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();
        int left = 0;
        string minWindow = string.Empty;

        if(s.Length < t.Length){
            return string.Empty;
        }

        foreach(char c in t){
            if(chars.ContainsKey(c)){
                chars[c]++;
            }else{
                chars[c] = 1;
                window[c] = 0;
            }
        }

        for(int i = 0; i < s.Length; i++){
            char current = s[i];
            if(chars.ContainsKey(current)){
                window[current]++;

                if(IsValid(chars, window)){
                    while(IsValid(chars, window)){
                        if(i - left < minWindow.Length - 1 || string.IsNullOrEmpty(minWindow)){
                            minWindow = s.Substring(left, i - left + 1);
                        }

                        if(window.ContainsKey(s[left])){
                            window[s[left]]--;
                        }

                        left++;
                    }
                }

            }
        }

        return minWindow;
    }

    private bool IsValid(Dictionary<char, int> chars, Dictionary<char, int> window){
        return 
            chars.Count == window.Count &&
            chars.All(x => window.TryGetValue(x.Key, out int value) && value >= x.Value);
    }
}
