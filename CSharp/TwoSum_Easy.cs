//link: https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] res = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            Console.WriteLine("{0}, {1}", i, diff);
            if (dict.ContainsKey(nums[i])) {
                Console.WriteLine(dict[nums[i]]);
                res = [i, dict[nums[i]]];
                return res;
            }
            else {
                if (!dict.ContainsKey(diff)) dict.Add(diff, i);
            }
        }
        return res;
    }

