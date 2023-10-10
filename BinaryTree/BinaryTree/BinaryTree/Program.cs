using BinaryTree;

public class Program {
    private static void Main(string[] args) {
        var bt = new BinaryTree<int>(1);
        bt.root.left = new Node<int>(2);
        bt.root.left.left = new Node<int>(3);

        bt.Delete(ref bt.root.left);

        Console.WriteLine(bt.root.left.data);
    }
}