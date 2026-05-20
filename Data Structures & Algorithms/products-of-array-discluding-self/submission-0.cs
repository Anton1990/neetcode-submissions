public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];
        int[] res = new int[nums.Length];
        prefix[0]=1;
        postfix[nums.Length-1]=1;

        for(int i = 1; i<nums.Length;i++){
            prefix[i]=nums[i-1]*prefix[i-1];
        }

        for(int i = nums.Length-2; i>=0;i--){
            postfix[i]=nums[i+1]*postfix[i+1];
        }

        for(int i = 0; i<nums.Length;i++){
            res[i]=prefix[i]* postfix[i];
        }

        return res;

    }
}
