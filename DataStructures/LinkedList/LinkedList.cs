using DataStructures.BinaryTree;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace DataStructures.LinkedList;

class Node<T> {
    public T? data;
    public Node<T>? next = null;

    public Node(T? data) {
        this.data = data;
    }

    public Node() {
        this.data = default(T);
    }
}

class SinglyLinkedList<T> : ICollection<T> {

    private Node<T> head;

    public Int32 Count { get {
            Node<T> node = head;
            Node<T> next = node.next;
            Int32 count = 0;
            while (next != null) {
                node = next;
                next = node.next;
                count++;
            }
            return count;
        } 
    }

    public T this[int key]
    {
        get {
            return Get(key);
        }
    }

    public Boolean IsReadOnly => false;

    public void Add(T item) {
        if (head == null) {
            head = new Node<T>(item);
        } else {
            GetLast().next = new Node<T>(item);
        }
    }

    public Node<T> GetLast() {
        Node<T> node = head;
        Node<T> next = node.next;
        while (next != null) {
            node = next;
            next = node.next;
        }
        return node;
    }

    public T Get(int index) {
        Node<T> node = head;
        Node<T> next = node.next;
        Int32 count = 0;
        while (next != null) {
            if (count == index) {
                return node.data;
            }
            node = next;
            next = node.next;
            count++;
        }
        return default(T);
    }

    public Node<T> GetNode(int index) {
        Node<T> node = head;
        Node<T> next = node.next;
        Int32 count = 0;
        while (next != null) {
            if (count == index) {
                return node;
            }
            node = next;
            next = node.next;
            count++;
        }
        return null;
    }

    public void Clear() {
        throw new NotImplementedException();
    }

    public Boolean Contains(T item) {
        for (int index = 0; index > this.Count + 1; index++) {
            if (EqualityComparer<T>.Default.Equals(this[index], item)) {
                return true;
            }
        }
        return false;
    }

    public void CopyTo(T[] array, Int32 arrayIndex) {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator() {
        Node<T> current = this.head;
        while (current != null) {
            yield return current.data;
            current = current.next;
        }
    }


    public Boolean Remove(T item) {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
