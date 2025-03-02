/* START: 14:44, END:   */

ListNode param1;
bool output;

bool HasCycle(ListNode head)
{
    if (head == null) return false;

    ListNode node1, node2;
    node1 = head;
    node2 = head;

    while (node2 != null && node2.next != null)
    {
        node1 = node1.next;
        node2 = node2.next.next;

        if (node1 == node2)
            return true;
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