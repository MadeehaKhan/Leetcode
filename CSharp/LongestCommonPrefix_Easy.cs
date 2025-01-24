//https://leetcode.com/problems/longest-common-prefix/
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0]; //we take the first string as the prefix
        for (int i = 1; i < strs.Length; i++)
        { //going through each of the REST of the strings
            while (strs[i].IndexOf(prefix) != 0)
            { //chopping off the end of the prefix until the prefix appears in the word
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }
        return prefix;
    }
}

//the IndexOf function is new to me:
//returns -1 if the other string (the prefix) is not found in the string
//we want it to return 0 because then the string begins with the prefix
