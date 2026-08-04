public class Solution {

    public string Encode(IList<string> strs) {
        string result = string.Empty;
        foreach(var item in strs){
            result+= item.Length + item + "#";
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();

        //return new List<string> () {s};
        
        for(int i = 0; i < s.Length; i++){
            if(char.IsDigit(s[i])
            {
                int length = 1;
                if(char.IsDigit(s[i + 1]){
                    length = int.Parse(s.Substring(i, 1));
                }
                else
                {
                    length = int.Parse(s[i].ToString());
                }

                string c = s.Substring(i + 1, length);
                result.Add(c);

                i += length;
            }            
        }

        return result;
   }
}
