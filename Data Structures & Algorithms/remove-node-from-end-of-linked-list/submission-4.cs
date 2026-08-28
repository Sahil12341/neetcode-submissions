/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null || (head.next == null && n == 1)) return null;
        ListNode fast = head;
        ListNode slow = head;
        int i = 1;
        while(i <= n && fast != null){
            fast = fast.next;
            i++;
        }
        if(fast == null){
            ListNode curr = head;
            head = head.next;
            curr.next = null;  
            return head;
        }
        while(fast !=null && fast.next != null){
            slow = slow.next;
            fast = fast.next;
        }
        slow.next = slow.next.next;

        return head;
    }
}
