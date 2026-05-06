public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = new int[2];
        Dictionary<int, int> diffs = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(diffs.ContainsKey(diff)) {
                return new int[] { diffs[diff], i };
            }
            diffs[nums[i]] = i;
        }
        return null;
    }
}
