public class Solution {

    public string Encode(IList<string> strs) {
        return string.Join("XxX", strs);
    }

    public List<string> Decode(string s) {
        return s.Split("XxX").ToList();
   }
}
