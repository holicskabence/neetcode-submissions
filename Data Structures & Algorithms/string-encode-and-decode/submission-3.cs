public class Solution {

    public string Encode(IList<string> strs) {
        return string.Join("XxX", strs);
    }

    public List<string> Decode(string s) {
        if(string.IsNullOrEmpty(s)){
            return new List<string>();
        }
        
        return s.Split("XxX").ToList();
   }
}
