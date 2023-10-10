using System.Collections;

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

    public Boolean IsReadOnly => throw new NotImplementedException();

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

    public void Clear() {
        throw new NotImplementedException();
    }

    public Boolean Contains(T item) {
        throw new NotImplementedException();
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
