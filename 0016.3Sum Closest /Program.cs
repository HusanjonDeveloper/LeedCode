
/*
Given an integer array nums of length n and an integer target, 
find three integers in nums such that the sum is closest to target.

    Return the sum of the three integers.

    You may assume that each input would have exactly one solution.

    Example 1:

Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
    Example 2:

Input: nums = [0,0,0], target = 1
Output: 0
Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
 

    Constraints:

3 <= nums.length <= 500
    -1000 <= nums[i] <= 1000
    -104 <= target <= 104
        
  */

          C# 

using System;
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int ans = int.MaxValue;
        int n = nums.Length;
        
        for (int i = 0; i < n; ++i) {
            int j = i + 1, k = n - 1;
            while (j < k) {
                int t = nums[i] + nums[j] + nums[k];
                if (t == target) {
                    return t;
                }
                if (Math.Abs(t - target) < Math.Abs(ans - target)) {
                    ans = t;
                }
                if (t > target) {
                    --k;
                } else {
                    ++j;
                }
            }
        }
        return ans;
    }
}

     
        Java 
        
        
        class Solution {
            public int threeSumClosest(int[] nums, int target) {
                Arrays.sort(nums);
                int ans = 1 << 30;
                int n = nums.length;
                for (int i = 0; i < n; ++i) {
                    int j = i + 1, k = n - 1;
                    while (j < k) {
                        int t = nums[i] + nums[j] + nums[k];
                        if (t == target) {
                            return t;
                        }
                        if (Math.abs(t - target) < Math.abs(ans - target)) {
                            ans = t;
                        }
                        if (t > target) {
                            --k;
                        } else {
                            ++j;
                        }
                    }
                }
                return ans;