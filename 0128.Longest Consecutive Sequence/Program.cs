﻿// C# 

using System;

public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        if (n < 2) {
            return n;
        }

        Array.Sort(nums);
        int ans = 1, t = 1;

        for (int i = 1; i < n; ++i) {
            if (nums[i] == nums[i - 1]) {
                continue;
            }
            if (nums[i] == nums[i - 1] + 1) {
                ans = Math.Max(ans, ++t);
            } else {
                t = 1;
            }
        }

        return ans;
    }
}


// Java 

class Solution {
    public int longestConsecutive(int[] nums) {
        int n = nums.length;
        if (n < 2) {
            return n;
        }
        Arrays.sort(nums);
        int ans = 1, t = 1;
        for (int i = 1; i < n; ++i) {
            if (nums[i] == nums[i - 1]) {
                continue;
            }
            if (nums[i] == nums[i - 1] + 1) {
                ans = Math.max(ans, ++t);
            } else {
                t = 1;
            }
        }
        return ans;
    }
}