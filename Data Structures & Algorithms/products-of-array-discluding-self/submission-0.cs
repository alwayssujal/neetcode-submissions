public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];

        for(int i = 0; i < output.Length; i++) {
            output[i] = 1;
        }

        int left = 1;
        for(int i = 0; i < nums.Length; i++) {
            output[i] *= left;
            left *= nums[i];
        }
        int right = 1;
        for(int i = nums.Length - 1; i >= 0; i--) {
            output[i] *= right;
            right *= nums[i]; 
        }
        return output;
    }
}
