public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new  Dictionary<int,int>();
        int targetDelta;
        int[] res = new int[2];

        for(int i =0; i<nums.Length;i++)
        {
            if(!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
            targetDelta  = target - nums[i];
            if(dict.ContainsKey(targetDelta))
            {
                res[0] = dict[targetDelta];
                res[1] = i;

            }
        }
        return res;



    }
}
