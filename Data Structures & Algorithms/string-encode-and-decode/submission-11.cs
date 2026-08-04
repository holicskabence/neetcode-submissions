public class Solution {

    public string Encode(IList<string> strs) {
        string result = string.Empty;
        foreach(var item in strs){
            result += "X" + item.Length + item;
        }

        return result;
    }

//"XX5WorldX5World""
    public List<string> Decode(string s) {
        var result = new List<string>();
//return new List<string>(){s};
        string lengthChars = string.Empty;
        bool isFirstChar = false;

        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsDigit(s[i]) && isFirstChar)
            {
                lengthChars += s[i];
            }
            else if(!string.IsNullOrEmpty(lengthChars))
            {
                var length = int.Parse(lengthChars);
                string curr = s.Substring(i, length);
                if(string.IsNullOrEmpty(curr)){
                    curr = "";
                }

                result.Add(curr);
                i += length - 1;
                isFirstChar = false;
                lengthChars = string.Empty;
                continue;
            }

            if(s[i] == 'X'){
                isFirstChar = true;
            }
        }

        if (!string.IsNullOrEmpty(lengthChars))
{
    int length = int.Parse(lengthChars);
    result.Add(s.Substring(s.Length, length)); // length itt 0, tehát ""
}

        return result;
   }
}
