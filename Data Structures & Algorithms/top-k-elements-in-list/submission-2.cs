public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var res = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int,int>();

        for(int i = 0; i<nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i],1);
            }
            else{
                dict[nums[i]]++;
            }
        }
        var list = new List<List<int>>();
        for(int i =0; i<=nums.Length; i++){
            list.Add(new List<int>());
          
        }
        foreach(var kvp in dict){
            list[kvp.Value].Add(kvp.Key);
        }
        for(int i = list.Count - 1; i>=1;i--)
        {
            for(int j = 0;j<list[i].Count;j++)
            {
                res.Add(list[i][j]);
            
                if (res.Count == k)
                {
                     res.ToArray();
                     return res.ToArray();
                }
            }
        }
       return res.ToArray();
    }
}