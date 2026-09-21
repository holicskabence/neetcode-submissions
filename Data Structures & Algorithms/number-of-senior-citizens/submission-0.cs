public class Solution {
    public int CountSeniors(string[] details) {
        int result = 0;
        for(int i = 0; i < details.Length; i++)
        {
            if(int.Parse(details[i][11].ToString() + details[i][12].ToString()) > 60)
            {
                result++;
            }
        }

        return result;
    }
}