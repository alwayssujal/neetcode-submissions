public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int x = target - nums[i];
            if(seen.ContainsKey(x)) {
                return new int[] { seen[x], i };
            }
            seen[nums[i]] = i;
        }
        return null;
    }
}
