public class Solution {

    public string Encode(IList<string> strs) {
        string result = string.Empty;
        foreach(var item in strs){
            result += item.Length + item;
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        string counter = string.Empty;

        for(int i = 0; i < s.Length; i++){
            if(char.IsDigit(s[i])){
                counter += s[i];
            }else{
                string curr = s.Substring(i, int.Parse(counter));
                result.Add(curr);
                i += int.Parse(counter) - 1;
                counter = string.Empty;
            }
        }

        return result;

   }
}
