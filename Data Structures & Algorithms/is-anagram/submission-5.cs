/*public class Solution {
    public bool IsAnagram(string s, string t) {
        if((s.Length != t.Length) || (s.Length == 0)) return false;
        List<char> helperList = new List<char>();
        foreach(char c in s) {
            helperList.Add(c);
        }

        foreach(char c in t) {
            if(helperList.Contains(c)){
                helperList.Remove(c);
            } else return false;
        }
        return helperList.Count == 0;
    }
}*/

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        int[] count = new int[26];
        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int val in count) {
            if (val != 0) {
                return false;
            }
        }
        return true;
    }
}
