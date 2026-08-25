public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
        Stack<char> stack = new();
        for(int i = 0; i < s.Length; i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                stack.Push(s[i]);
            }else if(stack.Count > 0 && s[i] == '}' && stack.Peek() == '{'||
                     stack.Count > 0 && s[i] == ')' && stack.Peek() == '('|| 
                     stack.Count > 0 && s[i] == ']' && stack.Peek() == '[')
            {
                stack.Pop();
            }else{
                return false;
            }
        }
        return stack.Count == 0;
    }
}
