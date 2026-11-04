public class TrieNode {
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool endOfWord = false;
}

public class PrefixTree {
    private TrieNode root;

    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach(char c in word) {
            if(!curr.children.ContainsKey(c)) {
                curr.children[c] = new TrieNode();
            }
            curr = curr.children[c];
        }
        curr.endOfWord = true;
    }
    
    public bool Search(string word) {
        var curr = root;
        foreach(char c in word) {
            if(!curr.children.ContainsKey(c))
                return false;
            curr = curr.children[c];
        }
        return curr.endOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var curr = root;
        foreach(var c in prefix) {
            if(!curr.children.ContainsKey(c))
                return false;
            curr = curr.children[c];
        }
        return true;
    }
}
