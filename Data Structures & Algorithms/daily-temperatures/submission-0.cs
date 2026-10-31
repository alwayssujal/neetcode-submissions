public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>();
        //[2,1,1,3]
        //[3,1,1,0]
        for(int i = 0; i < temperatures.Length; i++) {
            if (stack.Count > 0 && temperatures[i] > stack.Peek()[0]) {
                while (stack.Count > 0 && temperatures[i] > stack.Peek()[0]) {
                    int j = stack.Pop()[1];
                    res[j] = i - j;
                }
            }
            stack.Push(new int[] { temperatures[i], i});
        }
        return res;
    }
}
