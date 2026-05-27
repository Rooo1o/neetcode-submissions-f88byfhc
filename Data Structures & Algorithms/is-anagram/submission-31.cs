public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in s) {
            if(!dict.ContainsKey(c)) dict.Add(c, 0);
            dict[c]++;
        }

        foreach(char c in t) {
            if(!dict.ContainsKey(c) || dict[c] == 0) return false;
            dict[c]--;
        }

        foreach(int value in dict.Values) {
            if(value != 0) return false;
        }
        return true;
    }

























    /*public bool IsAnagramWithSorting(string s, string t) {
        char[] sortedS = s.ToCharArray();
        Array.Sort(sortedS);
        char[] sortedT = t.ToCharArray();
        Array.Sort(sortedT);
        return sortedS.SequenceEqual(sortedT);
    }*/

    /*public bool IsAnagram(string s, string t) {
        if((s.Length != t.Length) || (s.Length == 0)) return false;
        // Take a dictionary, add all of s's elements to it as key with value 1, and if the element already exists
        // we increment this key's value with 1, and looping over the t we do the opposite
        // declare one dictionary 

        Dictionary<char, int> dict = new Dictionary<char, int>();
        // add all of s's characters to it, if it already exists increment the value by 1
        for(int i = 0; i < s.Length; i++) {
            char c = s[i];
            if(!dict.ContainsKey(c)) dict[c] = 0;
            dict[c]++;
        }

        for(int i = 0; i < t.Length; i++) {
            char c = t[i];
            if (!dict.ContainsKey(c)) return false;
            dict[c]--;
            if (dict[c] == 0) dict.Remove(c);
        }*

        // return false if all of the dictionary's keys are gone (dictionary empty?)
        return dict.Count == 0;
    }*/
}
