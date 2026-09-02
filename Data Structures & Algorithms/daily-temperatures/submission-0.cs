public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<int> stack = new();
        for(int i = 0; i < n; i++){
        while(stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]){
                int index = stack.Pop();
                int diff = i - index;
                res[index] = diff;
            }
            stack.Push(i);
        }
        return res;
    }
}
