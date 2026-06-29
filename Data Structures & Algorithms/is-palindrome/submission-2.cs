public class Solution {
    public bool IsPalindrome(string s) {
        string trimmed = 
        s.Replace("?", "")
         .Replace("!", "")
         .Replace(".", "")
         .Replace(" ", "")
         .Replace("'", "")
         .Replace(",", "")
         .Replace(":", "")
         .ToLower();

        int length = trimmed.Length - 1;

        for (int i = 0; i < trimmed.Length; i++){
            if(trimmed[i] != trimmed[length - i]){
                return false;
            }
        }

        return true;
    }
}
