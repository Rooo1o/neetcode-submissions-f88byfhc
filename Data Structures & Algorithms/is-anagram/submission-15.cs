public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sortedS = s.ToCharArray();
        Array.Sort(sortedS);
        char[] sortedT = t.ToCharArray();
        Array.Sort(sortedT);
        return sortedS.SequenceEqual(sortedT);
    }
}
