namespace RemoveDupesSortedL;

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
public class Class1
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        List<int> list = new List<int>();

        if (head == null)
        {
            return null;
        }

        while (head != null)
        {
            if (!list.Contains(head.val))
            {
                list.Add(head.val);
            }
            head = head.next;
        }

        ListNode result = new ListNode(0, null);

        int counter = 0;

        foreach (int i in list.OrderBy(x => -x))
        {
            if (counter == 0)
            {
                result = new ListNode(i, null);
            }
            else
            {
                result = new ListNode(i, result);
            }
            counter++;
        }

        return result;
    }
}
