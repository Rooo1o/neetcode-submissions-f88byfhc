public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++){
            if(!hs.Add(nums[i])) return nums[i];
        } return 0;
    }
}
