public class Solution {
    public int FindMin(int[] nums) {
        // trivial solution 
        int lowest = Int32.MaxValue;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < lowest) lowest = nums[i];
        }
        return lowest;
        

        
    }
}
