/* START: 14:44, END:   */

bool HasCycle(ListNode head)
{
    HashSet<ListNode> hs = new HashSet<ListNode>();
    ListNode current = head;

    while (current != null) {
        if (hs.Contains(current))
            return true;
        hs.Add(current);
        current = current.next;
    }

    return false;
}


ListNode CreateLinkedListWithCycle(int[] nums, int pos)
{
    if (nums.Length == 0) return null;  // ถ้า Array ว่าง return null

    ListNode head = new ListNode(nums[0]);
    ListNode current = head;
    ListNode cycleEntry = null;

    for (int i = 1; i < nums.Length; i++)
    {
        current.next = new ListNode(nums[i]);
        current = current.next;

        // จำตำแหน่งของ Node ที่ต้องการให้เป็นจุดเริ่มต้นของ Cycle
        if (i == pos) cycleEntry = current;
    }

    // สร้าง Cycle: ให้ Node สุดท้ายชี้กลับไปยัง cycleEntry
    if (pos >= 0)
    {
        current.next = cycleEntry;
    }

    return head;
}

ListNode param1;
bool output;

param1 = CreateLinkedListWithCycle([3, 2, 0, -4], 1);
output = HasCycle(param1);

param1 = CreateLinkedListWithCycle([1, 2], 0);
output = HasCycle(param1);

int end = 0;


class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}