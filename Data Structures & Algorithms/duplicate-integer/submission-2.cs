public class Solution {
    public bool hasDuplicate(int[] nums) {
       Dictionary<int, int> dict = new();
       foreach(var num in nums){
        if(!dict.ContainsKey(num)){ dict[num] = 1; }
        else dict[num]++;
       }
       foreach(var value in dict.Values){
        if(value > 1) return true;
       }
       return false;
    }
}