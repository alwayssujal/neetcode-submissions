public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int area = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 1) {
                    area = Math.Max(area, Dfs(grid, r, c));
                }
            }
        }
        return area;
    }
    private int Dfs(int[][] grid, int r, int c) {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length 
            || grid[r][c] == 0) {
                return 0;
            }

        grid[r][c] = 0;
        return (1 + Dfs(grid, r + 1, c) +
                    Dfs(grid, r - 1, c) +
                    Dfs(grid, r, c + 1) +
                    Dfs(grid, r, c - 1));
    }
}
