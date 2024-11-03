// C#
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        foreach (int x in nums) {
            if (x != val) {
                nums[k++] = x;
            }
        }
        return k;
    }
}


// Java

class Solution {
    public int removeElement(int[] nums, int val) {
        int k = 0;
        for (int x : nums) {
            if (x != val) {
                nums[k++] = x;
            }
        }
        return k;
    }
}