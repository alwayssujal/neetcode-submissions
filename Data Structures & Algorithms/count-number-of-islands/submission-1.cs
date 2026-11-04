public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length, cols = grid[0].Length;
        int island = 0;

        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    Dfs(grid, i, j);
                    island++;
                }
            }
        }
        return island;
    }
    public void Dfs(char[][] grid, int r, int c) {
          if (r < 0 || c < 0 || r >= grid.Length ||
            c >= grid[0].Length || grid[r][c] == '0') {
            return;
        }

        grid[r][c] = '0';
        Dfs(grid, r - 1, c);
        Dfs(grid, r + 1, c);
        Dfs(grid, r, c - 1);
        Dfs(grid, r, c + 1);
    }
}
