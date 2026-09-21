public class Solution {
    public int CountSeniors(string[] details) {
        int result = 0;
        for(int i = 0; i < details.Length; i++)
        {
           if (details[i][11] > '6' || (details[i][11] == '6' && details[i][12] > '0'))
            {
                result++;
            }
        }

        return result;
    }
}