using Solutions;

namespace Tests;

public class AddTwoNumbersTests
{
    [Fact]
    public void Empty()
    {
        var l1 = new ListNode(0);
        var l2 = new ListNode(0);        
        
        var output = AddTwoNumbers.Run(l1, l2);
        Assert.Equal(0, output.val);
    }    
    
    [Fact]
    public void FirstTestCase()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));        
        
        var output = AddTwoNumbers.Run(l1, l2);
        Assert.Equal(7, output.val);
        Assert.Equal(0, output.next!.val);
        Assert.Equal(8, output.next!.next!.val);        
    }
    
    [Fact]
    public void ComplexNumber()
    {
        var l1 = new ListNode(9);
        var l2 = new ListNode(9, new ListNode(9));
        
        var output = AddTwoNumbers.Run(l1, l2);
        Assert.Equal(8, output.val);
        Assert.Equal(0, output.next!.val);
        Assert.Equal(1, output.next!.next!.val);        
    }
}