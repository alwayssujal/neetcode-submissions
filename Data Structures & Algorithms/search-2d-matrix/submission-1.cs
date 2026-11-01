public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length, cols = matrix[0].Length;
        int top = 0, bot = rows - 1;
        int row = 0;

        while (top <= bot) {
            row = (top + bot) / 2;

            if (target > matrix[row][cols - 1]) {
                top = row + 1;
            } 
            else if (target < matrix[row][0]) {
                bot = row - 1;
            }
            else {
                break;
            }
        }
        if (!(top <= bot)) {
            return false;
        }
        int left = 0, right = cols - 1;

        while (left <= right) {
            int m = (left + right) / 2;

            if (target > matrix[row][m]) {
                left = m + 1;
            }
            else if (target< matrix[row][m]) {
                right = m - 1;
            }
            else{
                return true;
            }
        }
        return false;
    }
}
