public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> list = new();
        Array.Sort(nums);
        int l, r;
        for(int i = 0; i < nums.Length; i++){
            if(i > 0 && nums[i] == nums[i - 1]){
                continue;
            }
            l = i + 1; r = nums.Length - 1;
            while(l < r){
                if(nums[i] + nums[l] + nums[r] == 0){
                   list.Add([nums[i], nums[l], nums[r]]);
                   l++;
                   while(l < r && nums[l] == nums[l - 1]){
                    l++;
                   }
                }else if(nums[i] + nums[r] + nums[l] > 0){
                    r--;
                    while(l < r && nums[r] == nums[r + 1]){
                    r--;
                   }
                }else{
                    l++;
                }
            }
        }
        return list;
    }
}
