public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i< nums.Length;i++){
           if(!dict.ContainsKey(nums[i])){
            dict.Add(nums[i],1) ;
           }
           else{
            dict[nums[i]]++;
           }
        }
        int j = 0;
        var res = new int[k];
        foreach(var kvp in dict.OrderByDescending(kvp => kvp.Value)){
            if(j<k){
                res[j] = kvp.Key;
                j++;
            }
      
        }
        return res;

    }
}
