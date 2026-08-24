public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] res = new int[n];
        int total = 1;
        for(int i = 0; i < n; i++){
            res[i] = total;
            total = total * nums[i];
        }

        total = 1;
        for(int i = n - 1; i >= 0; i--){
            res[i] = res[i] * total;
            total = total * nums[i];
        }
        return res;
    }
}
