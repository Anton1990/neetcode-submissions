public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //1. move all in Dictionary<string,strng>
        // string[i] strin[i].sort
        //2. прохожу по строке и преобразую строку в остортированную строку
        //
        List<List<string>> res = new List<List<string>>();
        Dictionary<string,List<string>> dict = new Dictionary<string, List<string>>();
     
        for(int i = 0; i<strs.Length; i++)
        {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);

            string sort = new string(chars);
            if(!dict.ContainsKey(sort)){
                dict.Add(sort,new List<string>{strs[i]});
            }
            else{
                dict[sort].Add(strs[i]);
            }
        }
        foreach (var kvp in dict){
            res.Add(kvp.Value);
        }
        return res;

    }
}
