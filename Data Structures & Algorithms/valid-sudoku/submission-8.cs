public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // check all rows
        var hs = new HashSet<char>();
        for(int rw = 0; rw < 9; rw++) {
            hs = new HashSet<char>();
            for(int cl = 0; cl < 9; cl++) {
                char c = board[rw][cl];
                if(Char.IsDigit(c)){
                    if(!hs.Add(c)) return false;
                }
            }
        }
        // check all columns
        for(int rw = 0; rw < 9; rw++) {
            hs = new HashSet<char>();
            for(int cl = 0; cl < 9; cl++) {
                char c = board[cl][rw];
                if(Char.IsDigit(c)){
                    if(!hs.Add(c)) return false;
                }
            }
        }
        // check all boxes
        for (int box = 0; box < 9; box++) {
        var set = new HashSet<char>();

        for (int i = 0; i < 9; i++) {
        int r = (box / 3) * 3 + i / 3;
        int c = (box % 3) * 3 + i % 3;

        char val = board[r][c];
        if (val == '.') continue;

        if (!set.Add(val)) return false;
    }
}     
        return true;
    }
}
