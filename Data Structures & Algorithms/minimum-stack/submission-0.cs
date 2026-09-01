public class MinStack {

    private Stack<int> stack;
    private Stack<int> stackMin;
    
    public MinStack() {
        stack = new Stack<int>();
        stackMin = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(stackMin.Count == 0){
            stackMin.Push(val);
        }
        else if(stackMin.Peek() >= val){
            stackMin.Push(val);
        }
    }
    
    public void Pop() {
        if(stack.Count > 0){
            int a = stack.Pop();
            if(stackMin.Count > 0 && stackMin.Peek() == a){
                stackMin.Pop();
            }
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return stackMin.Peek();
    }
}
