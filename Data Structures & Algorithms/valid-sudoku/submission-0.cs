public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new List<char>[9];
        var columns = new List<char>[9];
        var boxes = new List<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new List<char>();
            columns[i] = new List<char>();
            boxes[i] = new List<char>();
        }

        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                var current = board[i][j];
                if(char.IsDigit(current)){
                    int box = (i / 3) * 3 + (j / 3);

                    if(rows[i].Any(x => x == current) || columns[j].Any(x => x == current) || boxes[box].Any(x => x == current))
                    {
                        return false;
                    }
                    else
                    {
                        rows[i].Add(current);
                        columns[j].Add(current);
                        boxes[box].Add(current);
                    }
                }
            }
        }

        return true;
    }
}
