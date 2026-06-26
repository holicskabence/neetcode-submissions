public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();

        for(int i = 0; i < strs.Count(); i++)
        {
            bool alreadyAdded = false;
            for(int j = 0; j < result.Count(); j++)
            {
                if(IsAnagrams(strs[i], result[j][0]))
                {
                    result[j].Add(strs[i]);
                    alreadyAdded = true;
                    break;
                }
            }

            if(!alreadyAdded){
                result.Add(new List<string>(){strs[i]});
            }
        }

        return result;
    }

    private bool IsAnagrams(string x, string y){
        if(x.Length != y.Length){
            return false;
        }

        var dict = new Dictionary<char, int>();
        for(int i = 0; i < x.Length; i++)
        {
            if(dict.ContainsKey(x[i]))
            {
                dict[x[i]]++;
            }
            else
            {
                dict.Add(x[i], 1);
            }

            if(dict.ContainsKey(y[i]))
            {
                dict[y[i]]--;
            }
            else
            {
                dict.Add(y[i], -1);
            }
        }

        foreach(var item in dict)
        {
            if(item.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
