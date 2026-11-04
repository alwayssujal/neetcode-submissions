public class TrieNode {
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool word = false;
}
public class WordDictionary {
    TrieNode root;
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode curr = root;
        foreach(char c in word) {
            if(!curr.children.ContainsKey(c)) {
                curr.children[c] = new TrieNode();
            }
            curr = curr.children[c];
        }
        curr.word = true;
    }
    
    public bool Search(string word) {
        return Dfs(word, 0, root);
    }
    private bool Dfs(string word, int j, TrieNode root) {
        TrieNode curr = root;
        for(int i = j; i < word.Length; i++) {
            if(word[i] == '.') {
                foreach(var child in curr.children.Values) {
                    if (Dfs(word, i + 1, child)) {
                        return true;
                    }
                }
                return false;
            }
            else{
                if (!curr.children.ContainsKey(word[i])) {
                    return false;
                }
                curr = curr.children[word[i]];
            }
        }
        return curr.word;
    }
}
