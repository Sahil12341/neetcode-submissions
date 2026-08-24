public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        dict[nums[0]] = 0;
        for(int i = 1 ; i < nums.Length; i++){
            int complement = target - nums[i];
            if(dict.ContainsKey(complement)){
                return [dict[complement], i];
            }else{
                dict[nums[i]] = i;
            }
        }
        return [-1, -1];
    }
}
