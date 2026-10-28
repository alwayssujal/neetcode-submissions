public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0, end = numbers.Length - 1;

        while (start < end) {
            int sum = numbers[start] + numbers[end];
            if (sum == target) {
                return new int[] {start + 1, end + 1};
            } 
            if(sum < target) {
                start++;
            } 
            else {
                end--;
            }
        }
        return null;
    }
}
