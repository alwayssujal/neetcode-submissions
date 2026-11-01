public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int greatestElementToRight = -1;

        for (int i = arr.Length - 1; i >= 0; i--) {
            int temp = arr[i];
            arr[i] = greatestElementToRight;
            greatestElementToRight = Math.Max(greatestElementToRight, temp);
        }
        return arr;
    }
}