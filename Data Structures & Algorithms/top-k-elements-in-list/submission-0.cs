public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(int num in nums) {
            if(!dict.ContainsKey(num)) dict.Add(num, 0);
            dict[num]++;
        }
        var output = new int[k];
        for(int counter = 0; counter < k; counter++) {
            var maxPair = dict.MaxBy(kvp => kvp.Value);
            output[counter] = maxPair.Key;
            dict.Remove(maxPair.Key);
        }
        return output;
    }
}
