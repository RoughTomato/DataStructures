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
            if (head == null) return 0;

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

        if (index > this.Count || index < 0) {
            throw new IndexOutOfRangeException();
        }

        for (int i = 0; i < index; i++) {
            node = node.next;
        }
        return node.data;
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
        for (int i = this.Count; i > 0 ; i--) {
            RemoveAt(i);
        }
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
        if (Count == 0 || arrayIndex >= Count) {
            return;
        }

        var current = GetNode(arrayIndex);

        int destinationCounter = 0;
        int arrayLength = array.Length;

        while (current != null && destinationCounter < arrayLength) {
            array[destinationCounter] = current.data;
            current = current.next;
            destinationCounter++;
        }
    }

    public IEnumerator<T> GetEnumerator() {
        Node<T> current = this.head;
        while (current != null) {
            yield return current.data;
            current = current.next;
        }
    }

    public Boolean Remove(T item) {
        if (this.head == null) {
            return false;
        }
        Node<T> node = head;
        Node<T> next = node.next;
        Node<T>? prev;
        while (next != null) {
            prev = node;
            next = node.next;
            if (EqualityComparer<T>.Default.Equals(node.data, item)) {
                node = prev;
                prev.next = node;
            }
        }

        return false;
    }

    public Boolean RemoveAt(int index) {
        if (index > this.Count || index < 0) {
            throw new IndexOutOfRangeException();
        }

        if (this.head == null) {
            return false;
        }

        Node<T> tmp = head;

        if (index == 0) {
            head = tmp.next;
            return true;
        }

        for (int count = 0; tmp != null && count < index - 1; count++) {
            tmp = tmp.next;
        }

        Node<T> next = tmp.next.next;
        tmp.next = next;

        return true;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
