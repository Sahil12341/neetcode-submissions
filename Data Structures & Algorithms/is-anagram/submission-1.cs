public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> dict = new();
        foreach(char ch in s){
            if(!dict.ContainsKey(ch)){
                dict[ch] = 1;
            }else dict[ch]++;
        }
        foreach(var ch in t){
            int count = 0;
            if(dict.ContainsKey(ch) && dict[ch] > 0){
                dict[ch]--;
                count++;
            }
            if(count == 0){
                return false;
            }
        }
        return true;
    }
}
