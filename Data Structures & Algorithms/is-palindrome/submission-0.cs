public class Solution {
    public bool IsPalindrome(string s) {
        bool isPalindrome = true;
        int a = 0;
        int z = s.Length-1;
        while (a < z) {
            if(!char.IsLetterOrDigit(s[a])){
                s = s.Remove(a, 1);
                z--;
                continue;
            }
            if(!char.IsLetterOrDigit(s[z])){
                s = s.Remove(z, 1);
                z--;
                continue;
            }
            // if the length of the string is odd 
            // then the middle character should be skipped entirely 
            if (a >= Math.Floor(((double)s.Length/2)) && s.Length % 2 != 0) break;
            if (char.ToLower(s[a]) != char.ToLower(s[z])) isPalindrome = false;
            a++; 
            z--;
        }
        return isPalindrome;
    }
}
