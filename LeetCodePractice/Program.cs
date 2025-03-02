/* START: 16:24, END:   */

IList<double> AverageOfLevels(TreeNode root)
{
    List<double> avgs = [];
    List<int> count = [];

    if (root == null)
        return avgs;

    avgs.Add(root.val);
    count.Add(1);

    Stack<(int, TreeNode)> stack = new();
    if (root.left != null)
        stack.Push((1, root.left));

    if (root.right != null)
        stack.Push((1, root.right));

    while (stack.Count > 0)
    {
        var (level, node) = stack.Pop();

        if (level > avgs.Count - 1)
        {
            avgs.Add(node.val);
            count.Add(1);
        }
        else
        {
            avgs[level] += node.val;
            count[level] += 1;
        }

        if (node.left != null)
            stack.Push((level + 1, node.left));

        if (node.right != null)
            stack.Push((level + 1, node.right));
    }

    for (int idx = 0; idx < avgs.Count; idx++)
    {
        avgs[idx] = avgs[idx] / count[idx];
    }

    return avgs;
}

TreeNode param1;
IList<double> output;

param1 = CreateBinaryTree([3, 9, 20, null, null, 15, 7]);
output = AverageOfLevels(param1);

param1 = CreateBinaryTree([3,9,20,15,7]);
output = AverageOfLevels(param1);

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
