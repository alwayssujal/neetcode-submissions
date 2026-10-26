public class Solution {
    public int LongestConsecutive(int[] nums) {
        int longest = 0;
        HashSet<int> store = new HashSet<int>(nums);
        foreach(int num in nums) {
            int streak = 0, current = num;
            while (store.Contains(current)) {
                streak++;
                current++;
            }
            longest = Math.Max(longest, streak);
        }
        return longest;
    }
}
