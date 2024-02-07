namespace Solutions;

/**
 * Definition for singly-linked list.
 */
public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next=null) {
        this.val = val;
        this.next = next;
    }
}

//https://leetcode.com/problems/add-two-numbers/
public static class AddTwoNumbers {
    public static ListNode Run(ListNode l1, ListNode l2)
    {
        var l1Node = l1;
        var l2Node = l2;
        var remainder = false;

        var nodes = new ListNode();
        ListNode? previous = null;
        var keep = true;
        while (keep) 
        {
            var l1Value = l1Node?.val ?? 0;
            var l2Value = l2Node?.val ?? 0;

            var current = l1Value + l2Value ;
            if (remainder)
                current++;

            remainder = current >= 10;

            var node = previous is null ? nodes : new ListNode();
            node.val = remainder ? current % 10 : current;

            if (previous is not null)
            {
                previous.next = node;
            }

            previous = node;

            l1Node = l1Node?.next;
            l2Node = l2Node?.next;

            keep = l1Node is not null || l2Node is not null || remainder;
        }
        
        return nodes;
    }
}