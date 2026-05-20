public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        if(s.Length!=t.Length)
        {
            return false;
        }

        for(int i=0;i<s.Length; i++)
        {
            if(!dict.ContainsKey(s[i])){
                dict[s[i]] = 1;
            }
            else
            {
                dict[s[i]] = dict[s[i]] + 1;
            }
        }

        for(int i=0;i<t.Length; i++)
        {
            if(!dict.ContainsKey(t[i])){
                return false;
            }
            else
            {
                dict[t[i]] = dict[t[i]] - 1;
            }
               if( dict[t[i]]==-1 ){
                return false;
            }
        }
        return true;
        
    }
}
