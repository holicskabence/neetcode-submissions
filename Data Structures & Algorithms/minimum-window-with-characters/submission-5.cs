public class Solution {
    public string MinWindow(string s, string t) {
        string result = string.Empty;
        var chars = new Dictionary<char, int>();
        foreach(var c in t){
            chars[c]++;
        }

        var current = new Dictionary<char, int>();
        for(int i = 0; i < t.Length; i++){
            if(chars.ContainsKey(s[i])){
                current[i]++;
            }
        }

        return result;
    }
}
