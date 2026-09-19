public class Solution {
    public int LengthOfLastWord(string s) {
        var sArray = s.Trim().Split(" ");
        return sArray[sArray.Length - 1].Length;
    }
}