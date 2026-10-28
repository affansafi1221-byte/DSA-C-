
using DSA.LinkedList;

var list = new SinglyLinkedList<int>();

list.AddLast(10);
list.AddLast(20);
list.AddLast(30);

list.Print();

list.Reverse();
list.Print();

list.Remove(20);
list.Print();

Console.ReadKey();
