public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length < 2) return false;
        var dictionary = new Dictionary<int, int>();
        dictionary.Add(nums[0], nums[0]);
        for(int n = 1; n < nums.Length; n++) {
            if(dictionary.ContainsKey(nums[n])) {
                return true;
            }
            dictionary.Add(nums[n], nums[n]);
        }
        return false;
    }
}