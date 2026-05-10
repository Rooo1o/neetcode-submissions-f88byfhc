public class Solution {
    public bool IsPalindrome(string s) {
        int a = 0;
        int z = s.Length-1;
        while (a < z) {
            if(!char.IsLetterOrDigit(s[a])){
                a++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[z])){
                z--;
                continue;
            }
            if (char.ToLower(s[a]) != char.ToLower(s[z])) return false;
            a++; 
            z--;
        }
        return true;
    }
}
