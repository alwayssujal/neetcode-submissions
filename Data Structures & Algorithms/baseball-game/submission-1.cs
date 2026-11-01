public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        int totalSum = 0;

        foreach(string s in operations) {
            if (s == "+") {
                int a = stack.Pop();
                int b = stack.Peek();
                int sum = a + b;
                stack.Push(a);
                stack.Push(sum);
                totalSum += sum;
            }
            else if (s == "C") {
                totalSum -= stack.Pop();
            }
            else if (s == "D") {
                int dVal = stack.Peek() * 2;
                stack.Push(dVal);
                totalSum += dVal;
            }
            else {
                int num = int.Parse(s);
                stack.Push(num);
                totalSum += num;
            }
        }
        return totalSum;
    }
}