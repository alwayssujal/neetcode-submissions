public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";
        foreach(string str in strs) {
            encodedString += str.Length.ToString() + "#" + str;
        }
        return encodedString;
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            strs.Add(s.Substring(j + 1, length));
            i = j + 1 + length;
        }
        return strs;
   }
}
