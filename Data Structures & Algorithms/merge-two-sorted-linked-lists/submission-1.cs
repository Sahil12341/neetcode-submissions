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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        while(list1 != null || list2 != null){
            ListNode prog = new ListNode(0);
            
            int val1 = list1 != null ? list1.val : int.MaxValue;
            int val2 = list2 != null ? list2.val : int.MaxValue;
            if(val1 < val2){
                prog.val = val1;
                list1 = list1.next;
            }else{
                prog.val = val2;
                list2 = list2.next;
            }
            curr.next = prog;
            curr = curr.next; 
        }
        return dummy.next;
    }
}