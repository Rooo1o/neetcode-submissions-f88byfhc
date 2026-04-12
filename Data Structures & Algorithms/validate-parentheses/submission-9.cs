public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
        Dictionary<char, char> dClosers = new Dictionary<char, char>();
        var openers = new HashSet<char> {'(', '{', '['};
        dClosers.Add(')', '(');
        dClosers.Add('}', '{');
        dClosers.Add(']', '[');
        var stack = new Stack<char>();
        foreach (char c in s) {
            if (openers.Contains(c)) {
                stack.Push(c);
                continue; 
            }
            if(stack.Count == 0) {
                return false;
            }
            if(dClosers.TryGetValue(c, out char value)){
                if(stack.Pop() != value) return false;
            }
        }
        return stack.Count == 0;
    }
}
