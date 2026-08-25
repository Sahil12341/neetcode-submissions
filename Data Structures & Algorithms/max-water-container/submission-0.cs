public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int maxArea = int.MinValue;
        while(left < right){
            int width = right - left;
            int height = Math.Min(heights[left], heights[right]);
            int area = height * width;
            maxArea = Math.Max(area, maxArea);
            if(heights[left] < heights[right]){
                left++;
            }else{
                right--;
            }
        }
        return maxArea;
    }
}
