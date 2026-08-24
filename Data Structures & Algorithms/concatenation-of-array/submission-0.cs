public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int firstPtr = 0, secondPtr = 0;
        int[] ans = new int[2 * nums.Length];
        while(secondPtr < nums.Length){
            if(firstPtr < nums.Length){
                ans[firstPtr] = nums[firstPtr];
                firstPtr++;
            }
            else{
                ans[secondPtr + nums.Length] = nums[secondPtr];
                secondPtr++;
            }
        }
        return ans;
    }
}