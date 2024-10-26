/*
6. Zigzag Conversion
    Solved
Medium
    Topics
Companies
    The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
    Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);


Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
    A   L S  I G
Y A   H R
P     I
Example 3:

Input: s = "A", numRows = 1
Output: "A"


Constraints:

1 <= s.length <= 1000
s consists of English letters (lower-case and upper-case), ',' and '.'.
1 <= numRows <= 1000
*/

using System.Text;

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) {
            return s;
        }
        int n = s.Length;
        StringBuilder[] g = new StringBuilder[numRows];
        for (int j = 0; j < numRows; ++j) {
            g[j] = new StringBuilder();
        }
        int i = 0, k = -1;
        foreach (char c in s.ToCharArray()) {
            g[i].Append(c);
            if (i == 0 || i == numRows - 1) {
                k = -k;
            }
            i += k;
        }
        StringBuilder ans = new StringBuilder();
        foreach (StringBuilder t in g) {
            ans.Append(t);
        }
        return ans.ToString();
    }
}