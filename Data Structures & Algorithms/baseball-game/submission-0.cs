public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        
        foreach(string s in operations) {
            if (s == "+") {
                int a = stack.Pop();
                int b = stack.Peek();
                stack.Push(a);
                stack.Push(a + b);
            }
            else if (s == "C") {
                stack.Pop();
            }
            else if (s == "D") {
                stack.Push(stack.Peek() * 2);
            }
            else {
                stack.Push(int.Parse(s));
            }
        }
        int totalSum = 0;
        while (stack.Count > 0) {
            totalSum += stack.Pop();
        }
        return totalSum;
    }
}