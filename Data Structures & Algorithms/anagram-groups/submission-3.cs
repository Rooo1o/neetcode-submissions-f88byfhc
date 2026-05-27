public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        foreach(string str in strs) {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedString = new string(charArray);
            if(!dict.ContainsKey(sortedString)) dict[sortedString] = new List<string>();
            dict[sortedString].Add(str);
        }
        return dict.Values.ToList<List<string>>();
    }


























    /*
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach(var s in strs) {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedS = new string(charArray);
            // if sortedS does not already exist as a key in the dictionary, we define a new array
            if (!res.ContainsKey(sortedS)) {
                res[sortedS] = new List<string>();
            }
            res[sortedS].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }*/
}
