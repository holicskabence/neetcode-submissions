public class Solution {

    public string Encode(IList<string> strs) {
        string result = string.Empty;
        foreach(var item in strs){
            result += item.Length + "X" + item;
        }

        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        string lengthChars = string.Empty;

        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                lengthChars += s[i];
            }
            else
            {
                var length = int.Parse(lengthChars);
                string curr = s.Substring(i + 1, length);
                result.Add(curr);
                i += length;
                lengthChars = string.Empty;
            }
        }

        if (!string.IsNullOrEmpty(lengthChars))
        {
            int length = int.Parse(lengthChars);
            result.Add(s.Substring(s.Length, length));
        }

        return result;
   }
}
