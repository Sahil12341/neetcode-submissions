public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string pref = strs[0];
        int prefLen = pref.Length;
        for(int i = 1; i < strs.Length; i++){
            string currStr = strs[i];
            for(int j = 0; j < Math.Min(prefLen, currStr.Length); j++){
                if(pref[j] != currStr[j]){
                    prefLen = Math.Min(prefLen, j);
                    break;
                }
            }
                prefLen = Math.Min(prefLen, currStr.Length);
        }
        return pref.Substring(0, prefLen);
    }
}