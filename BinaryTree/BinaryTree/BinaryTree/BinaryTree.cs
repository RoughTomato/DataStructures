
namespace BinaryTree;
public class Node<T> {
    public T? data;
    public Node<T>? left;
    public Node<T>? right;

    public Node(){}
    public Node(T data) => this.data = data;
}

public class BinaryTree<T> {
    public readonly Node<T>? root;

    public BinaryTree(Node<T> root) => this.root = root;
    public BinaryTree(T data) => this.root = new Node<T>(data);

    public void Delete(ref Node<T> node) {
        if (node.right != null) {
            node = node.right;
        }
        else if (node.left != null) {
            node = node.left;
        }
        else {
            node = null; 
        }
    }
}
