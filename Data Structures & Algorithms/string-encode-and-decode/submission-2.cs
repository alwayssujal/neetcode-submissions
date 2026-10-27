public class Solution {

    public string Encode(IList<string> strs) {
        string encoded_string = "";
        foreach(string s in strs) {
            encoded_string += $"{s.Length}#{s}";
        }
        return encoded_string;
    }

    public List<string> Decode(string s) {
        var decoded_strs = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            j = i + length;
            decoded_strs.Add(s.Substring(i, length));
            i = j;
        }
        return decoded_strs;
   }
}
