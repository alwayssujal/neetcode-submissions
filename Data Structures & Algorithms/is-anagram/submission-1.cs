public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> sChar = new Dictionary<char, int>();
        foreach(char c in s) {
            if (sChar.ContainsKey(c)) {
                sChar[c]++;
            } 
            else {
                sChar[c] = 1;
            }
        }
        foreach(char c in t) {
            if (!sChar.ContainsKey(c) || sChar[c] == 0) {
                return false;
            }
            sChar[c]--;
        }
        return true;
    }
}
