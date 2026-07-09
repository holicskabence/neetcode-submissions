public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxLength = 0;
        var chars = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++){
            chars[s[i]] = chars.GetValueOrDefault(s[i]) + 1;
            var top = chars.MaxBy(x => x.Value);
            int others = chars.Where(x => x.Key != top.Key).Sum(x => x.Value);

            if(others > k){
                int currentLength = top.Value + others - 1;
                if(maxLength < currentLength){
                    maxLength = currentLength;
                }

                chars[s[left]] = chars.GetValueOrDefault(s[left]) - 1;
                left++;
            }
        }

        var lastTop = chars.MaxBy(x => x.Value);
        var lastOthers = chars.Where(x => x.Key != lastTop.Key).Sum(x => x.Value);

        if(lastOthers <= k){
            int currentLength = lastTop.Value + lastOthers;
            if(maxLength < currentLength){
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}
