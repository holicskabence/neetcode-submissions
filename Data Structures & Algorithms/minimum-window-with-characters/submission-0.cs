public class Solution {
    public string MinWindow(string s, string t) {
        string result = string.Empty;
        var chars = new Dictionar<char, int>();
        foreach(var c in t){
            chars[c]++;
        }

        var current = new Dictionar<char, int>();
        for(int i = 0; i < t.Length; i++){
            
        }
    }
}
