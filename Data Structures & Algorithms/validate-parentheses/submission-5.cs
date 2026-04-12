public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
        Dictionary<char, char> dOpeners = new Dictionary<char, char>();
        Dictionary<char, char> dClosers = new Dictionary<char, char>();
        var openers = new HashSet<char> {'(', '{', '['};
        var closers = new HashSet<char> {')', '}', ']'};
        dOpeners.Add('(', ')');
        dOpeners.Add('{', '}');
        dOpeners.Add('[', ']');
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
            } else {
                throw new ArgumentException("Something went very wrong here");
            }
        }
        return stack.Count == 0;
    }
}
