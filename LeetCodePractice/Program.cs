/* START: 16:24, END:   */

int MaxDepth(TreeNode root)
{
    if (root == null) return 0;

    int maxDepth = 0;
    Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();
    stack.Push((root, 1));

    while (stack.Count > 0)
    {
        var (leaf, depth) = stack.Pop();
        maxDepth = Math.Max(maxDepth, depth);

        if (leaf.left != null)
            stack.Push((leaf.left, depth + 1));

        if (leaf.right != null)
            stack.Push((leaf.right, depth + 1));
    }

    return maxDepth;
}

TreeNode param1;
int output;

param1 = CreateBinaryTree([3, 9, 20, null, null, 15, 7]);
output = MaxDepth(param1);

param1 = CreateBinaryTree([1, null, 2]);
output = MaxDepth(param1);

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

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x)
    {
        val = x;
        left = null;
        right = null;
    }
}
