
int count(ListNode node){
    int counter = 0;
    if(node?.next == null && counter == 0) return ++counter;
    void recurse(ListNode head){
        if(head != null){
            counter++;
            recurse(head.next);
        }
    }
    recurse(node);
    return counter;
}
ListNode getNnode(ListNode node,int n){
    if(n == 1) return node;
    return getNnode(node!.next, n - 1);
}
 ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(n == 0) return head;
        var get_next_ptr = (ListNode del_node) => del_node?.next ?? null;
        int nodes_count = count(head);
        if(nodes_count == 0) return head;
        else if(nodes_count == 1 && n == 1) return null;
        else if(nodes_count - n == 0) return head.next;
        var prev_node = getNnode(head,nodes_count - (n));
        prev_node.next = get_next_ptr(prev_node.next);
        return head;
}
public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next = null){
       this.val = val;
       this.next = next;
    }
}