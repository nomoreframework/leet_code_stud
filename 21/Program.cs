ListNode pointer = new ListNode();
ListNode tail_ptr = new ListNode();
    void merge(ListNode l1, ListNode l2,ListNode head){
            if(l1 == null || l2 == null){
                pointer = l1 != null ? l1 : l2;
                tail_ptr = head;
                return;
            }
            if(l1.val < l2.val){
                head.next = new ListNode(l1.val);
                merge(l1.next,l2,head.next);
            }
            else{
                head.next = new ListNode(l2.val);
                merge(l1,l2.next,head.next);
            }
        }
    ListNode MergeTwoLists(ListNode list1, ListNode list2){
        if(list1 == null && list2 == null) return list1!;
        else if(list1 == null || list2 == null) return list1 != null ? list1! : list2!;
        var result_head = new ListNode(list1.val < list2.val ? list1.val : list2.val);
            merge(list1.val <= list2.val ? list1.next : list1, 
                list2.val < list1.val ? list2.next : list2,
                result_head);
        tail_ptr.next = pointer;
        return result_head;
    }
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }