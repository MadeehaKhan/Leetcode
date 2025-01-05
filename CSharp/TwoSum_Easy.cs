//link: https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] res = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i]; //find the complement of this number
            if (dict.ContainsKey(nums[i])) { //if our number is already in our record, we just found its complement
                res = [i, dict[nums[i]]];
                return res;
            }
            else {
                if (!dict.ContainsKey(diff)) dict.Add(diff, i); //otherwise we need to keep track of where we found the complement of any possible pair
            }
        }
        return res;
    }

    //Easy once you understand how dictionaries work -- recording information that could be useful for later and instant lookup
    //The only optimization I see in this method is only computing diff if we are in the else case
    //I got stuck looking up dict[diff] instead of dict[num] but drawing out the problem helped 

