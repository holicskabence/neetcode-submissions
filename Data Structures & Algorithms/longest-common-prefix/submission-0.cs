public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var sorted = strs.OrderBy(x => x).ToList();
        string prefix = sorted[0];
        bool isValid = true;

        while(prefix.Length > 0)
        {
            for(int i = 1; i < sorted.Count; i++)
            {
                if(sorted[i].Substring(0, prefix.Length) != prefix)
                {
                    isValid = false;
                    break;
                }
            }

            if(isValid)
            {
                return prefix;
            }
            else
            {
                isValid = true;
            }

            prefix = sorted[0].Substring(0, prefix.Length - 1);
        }

        return prefix;
    }
}