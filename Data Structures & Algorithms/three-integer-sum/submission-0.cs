public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> ans = new List<List<int>>();
        Array.Sort(nums);
        //[-4,-1,-1,0,1,2]
        //a + b + c = 0
        for (int i = 0; i < nums.Length; i++) {
            //skip if duplicate found
            if (i > 0 && nums[i] == nums[i-1]) continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r) {

                int currSum = nums[i] + nums[l] + nums[r];
                if (currSum > 0) {
                    r--;
                }
                else if (currSum < 0) {
                    l++;
                }
                else {
                    ans.Add(new List<int> { nums[i], nums[l], nums[r]});
                    l++;
                    r--;
                    // Skip duplicate left values
                    while (l < r && nums[l] == nums[l - 1])
                        l++;

                    // Skip duplicate right values
                    while (l < r && nums[r] == nums[r + 1])
                        r--;
                }
            }
        }
        return ans;
    }
}
