public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs) {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        for (int i = 0; i < s.Length; ) {
            int j = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            strs.Add(s.Substring(i, length));
            i += length;
        }
        return strs;
    }
}