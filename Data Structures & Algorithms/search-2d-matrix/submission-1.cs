public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = 0;
        int n = matrix[0].Length - 1;
        
        while(m < matrix.Length)
        {
            if(target <= matrix[m][n] && target >= matrix[m][0])
            {
                int left = 0;
                int right = n;

                while(left <= right)
                {
                    int middle = (right - left) / 2 + left;

                    if(matrix[m][middle] == target)
                    {
                        return true;
                    }

                    if(matrix[m][middle] < target)
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
            }

            m++;
        }

        return false;
    }
}
