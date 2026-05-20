public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];
        Dictionary<int, int> dict = new Dictionary<int,int>();

        for(int i = 0; i<nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],1);
            }
            else{
                dict[nums[i]]++;
            }
        }
        int j = 0;
        foreach(KeyValuePair<int,int> kvp in dict.OrderByDescending(vp => vp.Value)){
            if(j<k){
                res[j] = kvp.Key;
                j++;
            }
        }

        return res;

}
}