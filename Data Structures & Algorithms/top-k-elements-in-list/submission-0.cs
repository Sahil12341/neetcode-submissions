public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict= new();
        foreach(int num in nums){
            if(!dict.ContainsKey(num)) dict[num] = 1;
            else dict[num]++;
        }
        int[] result = dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        return result;
    }
}
