public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int perimeter = 0;
        for(int i = 0; i < grid.Length; i ++){
            for(int j = 0; j < grid[0].Length; j ++){
                int current = grid[i][j];
                if(current == 1)
                {
                    if(j - 1 < 0 || grid[i][j - 1] == 0)
                    {
                        perimeter++;
                    }
                    if(j + 1 >= grid[0].Length || grid[i][j + 1] == 0)
                    {
                        perimeter++;
                    }
                    if(i - 1 < 0 || grid[i - 1][j] == 0)
                    {
                        perimeter++;
                    }
                    if(i + 1 >= grid.Length || grid[i + 1][j] == 0)
                    {
                        perimeter++;
                    }
                }
            }
        }

        return perimeter;
    }
}