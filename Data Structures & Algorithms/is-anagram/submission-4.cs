public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> chars = new Dictionary<char, int>();
        foreach(char c in s) {
            if (chars.ContainsKey(c)){
                chars[c]++;
            } else {
                chars[c] = 1;
            }
        }
        foreach(char c in t) {
            if (!chars.ContainsKey(c) || chars[c] == 0) {
                return false;
            } else {
                chars[c]--;
            }
        }
        return true;
    }
}
