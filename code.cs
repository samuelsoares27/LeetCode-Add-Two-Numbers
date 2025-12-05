
 //Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        return SomarRec(l1, l2, 0);
    }

    private ListNode SomarRec(ListNode l1, ListNode l2, int carry) {
        // caso base
        if (l1 == null && l2 == null && carry == 0)
            return null;

        int soma = carry;

        if (l1 != null)
            soma += l1.val;

        if (l2 != null)
            soma += l2.val;

        ListNode atual = new ListNode(soma % 10);

        int novoCarry = soma / 10;

        atual.next = SomarRec(
            l1 != null ? l1.next : null,
            l2 != null ? l2.next : null,
            novoCarry
        );

        return atual;
    }
}
