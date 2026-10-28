
using DSA.LinkedList;

namespace DSA.StackQueue;

public class MyStack<T>
{
    private Node<T>? top;
    public int Count { get; private set; }

    public void Push(T value)
    {
        var node = new Node<T>(value) { Next = top };
        top = node;
        Count++;
    }

    public T Pop()
    {
        if (top == null)
            throw new InvalidOperationException("Stack is empty");

        T value = top.Value;
        top = top.Next;
        Count--;
        return value;
    }

    public T Peek()
    {
        if (top == null)
            throw new InvalidOperationException("Stack is empty");

        return top.Value;
    }

    public bool IsEmpty() => top == null;
}
