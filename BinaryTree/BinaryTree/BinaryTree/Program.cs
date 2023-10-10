using BinaryTree;

public class Program {
    private static void Main(string[] args) {
        var bt = new BinaryTree<int>(1);
        bt.root.left = new Node<int>(2);
        bt.root.left.left = new Node<int>(3);
        bt.root.left.left.left = new Node<int>(4);
        bt.root.right = new Node<int>(5);
        bt.root.left.right = new Node<int>(6);
        bt.root.left.left.right = new Node<int>(7);

        Node<int> travel = bt.root.FindNodeByValue(bt.root, 6);

        if (travel != null) {
            Console.WriteLine($"Found node {travel.data}");
        }
        else {
            Console.WriteLine($"Couldn't find {travel.data}");
        }
    }
}