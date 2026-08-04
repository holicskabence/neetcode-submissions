public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(",", strs)));
        return encoded;
    }

    public List<string> Decode(string s) {
        string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(s));
        return s.Split(',').ToList();
   }
}
