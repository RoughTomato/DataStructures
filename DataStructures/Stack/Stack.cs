namespace DataStructures.Stack;
class Stack<T> {

    private T[] elements;
    private int top;
    private int max;

    private Stack(int size) {
        this.elements = new T[size];
        this.top = -1;
        this.max = size;
    }
    
    public int Size() {
        return top;
    }

    public T Pop() {
        if (this.top == -1) {
            throw new StackOverflowException();
        }

        return this.elements[this.top--];
    }

    public void Push(T item) {
        if (this.top == this.max - 1) {
            throw new StackOverflowException();
        }
        else {
            this.elements[++this.top] = item;
        }
    }

    public T Peek()
    {
        return elements[this.top];
    }
}
