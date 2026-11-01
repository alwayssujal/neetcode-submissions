public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen = new HashSet<char>();
        int l = 0;
        int res = 0;

        for (int r = 0; r < s.Length; r++) {
            while (seen.Contains(s[r])) {
                seen.Remove(s[l]);
                l++;
            }
            seen.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
