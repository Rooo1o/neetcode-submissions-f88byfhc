
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {       
        Dictionary<int, int> count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];

        // initialise every 
        for(int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        // fill up the dictionary with counting
        foreach(int n in nums) {
            count[n] = count.ContainsKey(n) ? count[n] + 1: 1; 
        }

        // for every item in the dictionary, we go to freq at the position entry.Value and add entry.Key
        foreach(var entry in count) {
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        // we count down from the size of the freq array, until index < k or i = 0
        for (int i = freq.Length - 1; i > 0 && index < k; i--) {
            // for every item in this array
            foreach (int n in freq[i]) {
                res[index++] = n;
                if (index == k) {
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
