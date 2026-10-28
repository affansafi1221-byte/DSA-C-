
using DSA.LinkedList;

namespace DSA.StackQueue;

public class MyQueue<T>
{
    private Node<T>? head;
    private Node<T>? tail;
    public int Count { get; private set; }

    public void Enqueue(T value)
    {
        var node = new Node<T>(value);

        if (tail == null)
        {
            head = tail = node;
        }
        else
        {
            tail.Next = node;
            tail = node;
        }

        Count++;
    }

    public T Dequeue()
    {
        if (head == null)
            throw new InvalidOperationException("Queue is empty");

        T value = head.Value;
        head = head.Next;

        if (head == null)
            tail = null;

        Count--;
        return value;
    }

    public bool IsEmpty() => head == null;
}
