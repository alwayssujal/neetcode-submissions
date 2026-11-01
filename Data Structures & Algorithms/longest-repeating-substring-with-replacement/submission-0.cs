public class Solution {
    public int CharacterReplacement(string s, int k) {
        //hashmap to count frequency
        //res to store longest value
        //length of window  - max letter inside that window <= k

        //if the window is not valid shift eh left pointer one step to right

        Dictionary<char, int> freq = new Dictionary<char, int>();
        int res = 0;
        int l = 0;
        int maxFreq = 0;
        
        for (int r = 0; r < s.Length; r++) {
            freq[s[r]] = freq.GetValueOrDefault(s[r], 0) + 1;
            maxFreq = Math.Max(maxFreq, freq[s[r]]);

            if (r - l + 1 - maxFreq <= k) {
                res = Math.Max(res, r - l + 1);
            }
            else {
                freq[s[l]] = freq[s[l]] - 1;
                l++;
            }
        }
        return res;
    }
}
