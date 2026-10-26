public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var ans = new Dictionary<string, List<string>>();        
        foreach(string s in strs) {
            int[] count = new int[26];
            foreach(char c in s) {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if (!ans.ContainsKey(key)) {
                ans[key] = new List<string>();
            }
            ans[key].Add(s);
        }
        return ans.Values.ToList<List<string>>();
    }
}
