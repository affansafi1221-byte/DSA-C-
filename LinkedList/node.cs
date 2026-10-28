
namespace DSA.LinkedList;

public class Node<T>
{
	public T Value;
	public Node<T>? Next;

	public Node(T value)
	{
		Value = value;
	}
}
