
namespace DSA.LinkedList;

public class SinglyLinkedList<T>
{
    private Node<T>? head;

    // Time: O(n), Space: O(1)
    public void AddLast(T value)
    {
        var newNode = new Node<T>(value);

        if (head == null)
        {
            head = newNode;
            return;
        }

        var current = head;

        while (current.Next != null)
            current = current.Next;

        current.Next = newNode;
    }

    // Time: O(n), Space: O(1)
    public bool Remove(T value)
    {
        if (head == null) return false;

        if (EqualityComparer<T>.Default.Equals(head.Value, value))
        {
            head = head.Next;
            return true;
        }

        var current = head;

        while (current.Next != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Next.Value, value))
            {
                current.Next = current.Next.Next;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    // Time: O(n), Space: O(1)
    public void Reverse()
    {
        Node<T>? previous = null;
        var current = head;

        while (current != null)
        {
            var next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        head = previous;
    }

    public void Print()
    {
        var current = head;

        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }

        Console.WriteLine("null");
    }
}
