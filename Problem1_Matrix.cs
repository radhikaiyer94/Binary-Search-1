// Time Complexity : O(logn)
// Space Complexity : O(1)
// Did this code successfully run on Leetcode : Yes
// Any problem you faced while coding this : After finding the mid element of the hypothetical 1D array using binary search, 
//                                           calculating the row and column of the mid element in the 2D matrix was challenging.

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int low = 0;
        int high = (rows * cols) - 1;
        bool isTargetExists = false;
        while (low <= high) {
            int mid = low + (high - low)/2;
            int row = mid / cols;
            int col = mid % cols;
            if (matrix[row][col] == target) {
                isTargetExists = true;
                break;
            }
            else if (matrix[row][col] < target) {
                low = mid + 1;
            }
            else {
                high = mid - 1;
            }
        }
        return isTargetExists;
    }
}
