public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach(string t in tokens) {
            if (t == "+") {
                stack.Push(stack.Pop() + stack.Pop());
            } else if (t == "-") {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            } else if (t == "*") {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (t == "/") {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b / a);
            }
            else {
                stack.Push(int.Parse(t));
            }            
        }
        return stack.Pop();
    }
}
