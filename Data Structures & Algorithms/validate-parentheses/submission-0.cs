public class Solution {
    public bool IsValid(string s) {
        int length = s.Length;

        for(int i = 0; i < length / 2 - 1; i++){
            if(!CompareBrackets(s[i], s[length - i - 1])){
                return false;
            }
        }

        return true;
    }

    private bool CompareBrackets(char left, char right){
        bool result = false;

        switch (left){
            case '(':
                result = right == ')';
                break;
            case '{':
                result = right == '}';
                break;
            case '[':
                result = right == ']';
                break;
        }

        return result;
    }
}
