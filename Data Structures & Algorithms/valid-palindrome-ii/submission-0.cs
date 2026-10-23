public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1; 

        while(left <= right)
        {
            if(s[left] != s[right])
            {
               return 
                IsPalidrome(s.Substring(left, right - left)) || 
                IsPalidrome(s.Substring(left + 1, right - left));
            }

            left++;
            right--;
        }

        return true;
    }

    private bool IsPalidrome(string s){
        int left = 0;
        int right = s.Length - 1; 

        while(left <= right)
        {
            if(s[left] != s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}