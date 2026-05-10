
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {       
        // [3, 1, 2, 3, 6, 6, 3, 2, 2, 2, 7]
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length+1];

        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        for(int i = 0; i < nums.Length; i++) {
            if(!dict.ContainsKey(nums[i])) dict[nums[i]] = 0;
            dict[nums[i]]++;
        }

        /* we now have each number. Dictionary looks like (key: value):
        3: 3
        1: 1
        2: 4
        6: 2
        7: 1
        */

        foreach(var entry in dict) {
            freq[entry.Value].Add(entry.Key);
        }

        // so our freq list looks like: 
        // [], [1, 7], [6], [3], [2], [], [], [], []

        int[] res = new int[k];
        int index = 0; 
        for(int i = freq.Length - 1; i > 0 && index < k; i--){
            foreach(int n in freq[i]) {
                res[index++] = n;
                if(index == k) {
                    return res;
                }
            }
        }
        return res;
    }   
}


/*public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {       
        // In the arrayofLists, the index is the count and the list are all the numbers that have that count. 
        List<int>[] arrayOfLists = new List<int>[nums.Length+1];

        // initialise every array, good enough for the first execution lmao 
        for(int x = 0; x < arrayOfLists.Length; x++) {
            arrayOfLists[x] = new List<int>();
        }

        // Loop over nums 
        for(int i = 0; i < nums.Length; i++) {
            // first we add nums[i] to the first list in the array, except if it's already there. in that case we do it to the next, except if it's already there too. 
            int currentNum = nums[i];
            int x = 0; 
            while(arrayOfLists[x].Contains(currentNum)) {
                x++;
            }
            arrayOfLists[x].Add(currentNum);
        }

        // we now have all numbers sorted by frequency ... now we just loop over k and populate our output and then exit this goddamn cursed algorithm 
        int[] output = new int[k];

        int countdown = arrayOfLists.Length-1;
        while(arrayOfLists[countdown] == null || arrayOfLists[countdown].Count == 0) {
            countdown--;
        }
        int z = 0;
        for(int i = 0; i < output.Length-1; i++) {
            output[i] = arrayOfLists[countdown][arrayOfLists[countdown].Count - z];
            if(arrayOfLists[countdown][arrayOfLists[countdown].Count - z] == 0) {
                // move countdown down by one and reset z
                countdown--;
                z = 1;
            } else { z++; }
        }
        return output;
    }
}*/

/*public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {       
        List<int>[] arrayOfLists = new List<int>[nums.Length+1];

        for(int x = 0; x < arrayOfLists.Length; x++) {
            arrayOfLists[x] = new List<int>();
        }

        for(int i = 0; i < nums.Length; i++) {
            int currentNum = nums[i];
            int x = 0; 

            // prevent x from going out of bounds
            while(x < arrayOfLists.Length && arrayOfLists[x].Contains(currentNum)) {
                x++;
            }

            if (x < arrayOfLists.Length) {
                arrayOfLists[x].Add(currentNum);
            }
        }

        int[] output = new int[k];

        int countdown = arrayOfLists.Length - 1;

        // prevent countdown from going below 0
        while(countdown >= 0 && (arrayOfLists[countdown] == null || arrayOfLists[countdown].Count == 0)) {
            countdown--;
        }

        int z = 1; // start at 1 to match indexing fix

        for(int i = 0; i < output.Length; i++) {
            if (countdown < 0) break;

            int index = arrayOfLists[countdown].Count - z;

            // ensure index is valid
            if (index < 0) {
                countdown--;
                z = 1;
                i--; // retry this position
                continue;
            }

            output[i] = arrayOfLists[countdown][index];
            z++;
        }

        return output;
    }
}*/
