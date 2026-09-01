public class Solution {
    public int EvalRPN(string[] tokens) {
        int n = tokens.Length;
        if(n == 1) return int.Parse(tokens[0]);
        Stack<string> stack = new();
        int res = 0;
        for(int i = 0; i < n; i++){
            string op = tokens[i];
            if(op == "+" || op == "-" || op == "*" || op == "/"){
                string num2 = stack.Pop();
                string num1 = stack.Pop();
                res = Calculate(num1, num2, op);
                stack.Push(res.ToString());
            }
            else{
                stack.Push(op);
            }
        }
        return res;
    }
}

public static int Calculate(string n1, string n2, string op){
    int num1 = int.Parse(n1);
    int num2 = int.Parse(n2);
    switch(op){
        case "+":
            return num1 + num2;
        case "-":
            return num1 - num2;
        case "*":
            return num1 * num2;
        case "/":
            return num2 != 0 ? num1 / num2 : 0;
        default:
            return 0;
    }
    return 0;
}