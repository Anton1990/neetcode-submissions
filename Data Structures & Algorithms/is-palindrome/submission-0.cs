public class Solution {
public bool IsPalindrome(string s)
{
    if (string.IsNullOrEmpty(s)) return true;

    int i = 0;
    int j = s.Length - 1;

    while (i < j)
    {
        // Move i to the next alphanumeric
        while (i < j && !char.IsLetterOrDigit(s[i]))
            i++;

        // Move j to the previous alphanumeric
        while (i < j && !char.IsLetterOrDigit(s[j]))
            j--;

        char left = char.ToLower(s[i]);
        char right = char.ToLower(s[j]);

        if (left != right)
            return false;

        i++;
        j--;
    }

    return true;
}
}
