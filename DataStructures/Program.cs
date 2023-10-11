using DataStructures.LinkedList;


SinglyLinkedList<int> ints = new SinglyLinkedList<int>();

ints.Add(1); //0
ints.Add(2); //1
ints.Add(3); //2
ints.Add(4); //3
ints.Add(5); //4
ints.Add(6); //5
ints.Add(7); //6
ints.Add(8); //7

Console.WriteLine($"Last {ints.GetLast().data}");
Console.WriteLine($"Count {ints.Count}");

for (int i = 0; i < ints.Count + 1; i++) {
    Console.WriteLine($"{i}:{ints[i]}");
}

ints.Clear();

Console.WriteLine($"{ints == null} {ints.Count}");