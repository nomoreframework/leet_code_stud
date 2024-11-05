var res = 10;
// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int c = 0)
    {
        if (l1 == null && l2 == null && c == 0) return null;

        int currentSum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + c;
        c = currentSum / 10;
        return new ListNode(currentSum % 10, AddTwoNumbers(l1?.next, l2?.next, c));
    }
}

