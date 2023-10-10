
namespace BinaryTree;
public class Node<T> {
    public T? data;
    public Node<T>? left;
    public Node<T>? right;

    public Node(){}
    public Node(T data) => this.data = data;

    public Node<T> FindNodeByValue(Node<T> node, T value) {
        if (node.data != null && EqualityComparer<T>.Default.Equals(node.data, value)) {
            return node;
        }
        
        if (node.left != null) {
            Node<T> ret = node.left.FindNodeByValue(node.left, value);
            if (ret != null) {
                return ret;
            }
        }

        if (node.right != null) {
            Node<T> ret = node.right.FindNodeByValue(node.right, value);
            if (ret != null) {
                return ret;
            }
        }

        return null;
    }
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
