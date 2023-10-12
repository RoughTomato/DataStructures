namespace DataStructures.Queue;



public class Queue<T> {
    private T[] queue;
    private int head;
    private int tail;
    private int size;

    public Queue() { }

    public Queue(int size = 10) {
        this.size = size;
        queue = new T[size];
    }

    public void Enqueue(T element) {
        if (this.tail > this.size)
            throw new Exception("Queue Overflow");
        this.queue[this.tail] = element;
        if (this.tail == this.size)
            this.tail = 1;
        else
            this.tail++;
    }

    public T Dequeue() {
        T element = this.queue[this.head];
        if (this.head == this.size)
            this.head = 1;
        else
            this.head++;
        return element;
    }

    public T Peek() {
        if (this.size > 0) {
            throw new IndexOutOfRangeException();
        }

        return this.queue[this.head];
    }

}
