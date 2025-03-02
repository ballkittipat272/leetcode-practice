/* START: 19:40, END:   */

int GetMinimumDifference(TreeNode root)
{
    return 0;
}

TreeNode param1;
int output;

param1 = CreateBinaryTree([4, 2, 6, 1, 3]);
output = GetMinimumDifference(param1);

param1 = CreateBinaryTree([1, 0, 48, null, null, 12, 49]);
output = GetMinimumDifference(param1);

int end = 0;


TreeNode CreateBinaryTree(object[] nodes)
{
    if (nodes.Length == 0 || nodes[0] == null)
        return null;

    TreeNode root = new TreeNode((int)nodes[0]);
    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    int i = 1;

    while (queue.Count > 0 && i < nodes.Length)
    {
        TreeNode current = queue.Dequeue();

        // สร้างลูกซ้าย (ถ้าไม่ใช่ null)
        if (i < nodes.Length && nodes[i] != null)
        {
            current.left = new TreeNode((int)nodes[i]);
            queue.Enqueue(current.left);
        }
        i++;

        // สร้างลูกขวา (ถ้าไม่ใช่ null)
        if (i < nodes.Length && nodes[i] != null)
        {
            current.right = new TreeNode((int)nodes[i]);
            queue.Enqueue(current.right);
        }
        i++;
    }

    return root;
}

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
