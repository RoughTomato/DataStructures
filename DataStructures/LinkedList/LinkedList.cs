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

class LinkedList<T> : ICollection<T> {
    public Int32 Count => throw new NotImplementedException();

    public Boolean IsReadOnly => throw new NotImplementedException();

    public void Add(T item) {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public Boolean Remove(T item) {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() {
        throw new NotImplementedException();
    }
}
