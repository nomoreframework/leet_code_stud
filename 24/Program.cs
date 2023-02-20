void swap(ref ListNode node){
    if(node == null) return;
    else if(node.next == null) return;
    else{
    ListNode buff  = new ListNode(node.val, node.next.next);
    node = node.next;
    node.next = buff;
    var r = node.next.next;
        swap(ref node.next.next);
    }    
}
class ListNode {
    public int val;
    public ListNode next; 
    public ListNode(int val = 0, ListNode next = null){
          this.val = val;
          this.next = next;
    }
}

