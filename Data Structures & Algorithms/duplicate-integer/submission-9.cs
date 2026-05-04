public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> ints = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(!ints.Add(nums[i])) return true;
        }
        return false;
    }
}