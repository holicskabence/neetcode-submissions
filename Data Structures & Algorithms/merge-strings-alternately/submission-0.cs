public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = string.Empty;
        int i = 0;
        int minLength = Math.Min(word1.Length, word2.Length);
        while(i < minLength)
        {
            result += word1[i];
            result += word2[i];
            i++;
        }

        if(word1.Length > minLength)
        {
            result += word1.Substring(i, word1.Length - i);
        }
        else if(word2.Length > minLength)
        {
            result += word2.Substring(i, word2.Length - i);
        }

        return result;
    }
}