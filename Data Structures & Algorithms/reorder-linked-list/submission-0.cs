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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode revStart = slow.next;
        slow.next = null;
        ListNode prev = null;
        ListNode nextCheck = revStart;
        while (revStart != null) {
            nextCheck = nextCheck.next;
            revStart.next = prev;
            prev = revStart;
            revStart = nextCheck;
        }
        slow = head;
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        while (prev != null || slow != null) {
            if (slow != null) {
                ListNode temp = slow;
                curr.next = temp;
                curr = curr.next;
                slow = slow.next;
            }
            if (prev != null) {
                ListNode temp = prev;
                curr.next = temp;
                curr = curr.next;
                prev = prev.next;
            }
        }
    }
}
