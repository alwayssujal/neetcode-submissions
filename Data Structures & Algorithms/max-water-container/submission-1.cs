public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int best = 0;

        while (l < r) {
            int height = Math.Min(heights[l], heights[r]);
            int width = r - l;
            int area = height * width;

            best = Math.Max(best, area);

            if (heights[l] <= heights[r]){
                l++;
            } else{
                r--;
            }
        }
        return best;
    }
}
