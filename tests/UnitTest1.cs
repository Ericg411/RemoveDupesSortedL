using RemoveDupesSortedL;
using System.Collections.Generic;

namespace tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        ListNode head = new ListNode(1, new ListNode(1, new ListNode(2, null)));
        ListNode result = _test.DeleteDuplicates(head);
        bool dupes = false;

        List<int> list = new List<int>();   

        while (result != null)
        {
            if (!list.Contains(result.val))
            {
                list.Add(result.val);
            } 
            else if (list.Contains(result.val))
            {
                dupes = true;
            }
            result = result.next;
        }

        Assert.IsFalse(dupes);

    } 
    
    [TestMethod]
    public void TestMethod2()
    {
        ListNode head = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, null)))));
        ListNode result = _test.DeleteDuplicates(head);
        bool dupes = false;

        List<int> list = new List<int>();   

        while (result != null)
        {
            if (!list.Contains(result.val))
            {
                list.Add(result.val);
            } 
            else if (list.Contains(result.val))
            {
                dupes = true;
            }
            result = result.next;
        }

        Assert.IsFalse(dupes);

    }
}