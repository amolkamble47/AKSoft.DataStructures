// See https://aka.ms/new-console-template for more information
Console.WriteLine("Linked List!");


var list = new AKSoft.DataStructures.LinkedList.LinkedList<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Print();
list.Remove(2);
list.Print();
list.Remove(3);
list.Print();
list.Remove(1);
list.Print();

Console.WriteLine($"{list.Count()}");
list.Clear();
list.AddAt(10001, 0);
list.AddAt(10002, 1);
list.AddAt(10003, 2);
list.AddAt(10004, 1);
list.AddAt(10005, 0);
list.AddAt(10006, 6);
list.Print();
