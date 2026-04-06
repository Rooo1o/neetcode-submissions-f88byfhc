public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        if(s.Length == 0 || t.Length == 0) return false;
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
}
