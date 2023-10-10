
namespace BinaryTree;

public enum BTNodeDirection {
    Left,
    Right
}

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

    public void InsertAfterValue(T value, Node<T> newNode, BTNodeDirection direction) {
        Node<T> node = root.FindNodeByValue(this.root, value);
        
        if (node != null) {
            if (BTNodeDirection.Left == direction) {
                node.left = newNode;
            }
            else {
                node.right = newNode;
            }
        }
    }

    /*
     * TODO: Add auxiliary operations (level, size)
     */
    public int GetHeight() {
        if (this.root == null) {
            return 0;
        }

        return this.Height(root);
    }

    private int Height(Node<T> node) {
        if (node == null) {
            return 0;
        }

        int leftHeight = this.Height(node.left);
        int rightHeight = this.Height(node.right);

        if (leftHeight > rightHeight) {
            return leftHeight+1;
        }
        else {
            return rightHeight+1;
        }
    }
}
