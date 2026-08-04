public class Solution {

    public string Encode(IList<string> strs) {
        return string.Join("#", strs);
    }

    public List<string> Decode(string s) {
        return s.Split('#').ToList();
   }
}
