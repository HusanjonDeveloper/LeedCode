/*
Given the head of a linked list, remove the nth node from the end of the list and return its head.
   
    
   
   Example 1:
   
   
   Input: head = [1,2,3,4,5], n = 2
   Output: [1,2,3,5]
   Example 2:
   
   Input: head = [1], n = 1
   Output: []
   Example 3:
   
   Input: head = [1,2], n = 1
   Output: [1]
    
   
   Constraints:
   
   The number of nodes in the list is sz.
   1 <= sz <= 30
   0 <= Node.val <= 100
   1 <= n <= sz
   
   */
   
   // C# 
   
   
   public class ListNode {
       public int val;
       public ListNode next;
       public ListNode(int val = 0, ListNode next = null) {
           this.val = val;
           this.next = next;
       }
   }

   public class Solution {
       public ListNode RemoveNthFromEnd(ListNode head, int n) {
           ListNode dummy = new ListNode(0, head);
           ListNode fast = dummy, slow = dummy;

           while (n-- > 0) {
               fast = fast.next;
           }

           while (fast.next != null) {
               slow = slow.next;
               fast = fast.next;
           }

           slow.next = slow.next.next;
           return dummy.next;
       }
   }


// Java 


   class Solution {
       public ListNode removeNthFromEnd(ListNode head, int n) {
           ListNode dummy = new ListNode(0, head);
           ListNode fast = dummy, slow = dummy;
           while (n-- > 0) {
               fast = fast.next;
           }
           while (fast.next != null) {
               slow = slow.next;
               fast = fast.next;
           }
           slow.next = slow.next.next;
           return dummy.next;
       }
   }