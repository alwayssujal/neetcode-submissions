public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int greatestElementToRight = arr[arr.Length - 1];
        arr[arr.Length - 1] = -1;

        for (int i = arr.Length - 2; i >= 0; i--) {
            int temp = arr[i];
            arr[i] = greatestElementToRight;
            greatestElementToRight = Math.Max(greatestElementToRight, temp);
        }
        return arr;
    }
}