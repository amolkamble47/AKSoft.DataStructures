namespace AKSoft.DataStructures.LinkedList;

public class LinkedList<T> {

    class Node {
        public Node Next {get; set; }
        public T? Data { get;set;}
    }

    private Node? Head { get; set; } 
    
    public void Add(T data) {

        var node = new Node() { Data = data };

        if (Head == null) {
            Head = node;
            return;
        } 

        var n = Head;
        while(n.Next != null) n = n.Next;
        n.Next = node;
    }

    public void AddAt(T data, int index) {
        
        if (index < 0) { 
            throw new AKSoft.DataStructures.Core.Exception.InvalidArgumentException("INDEX_OUT_OF_BOUND"); 
        }

        Node n = Head;
        Node p = null;
        while (index-- > 0 && n != null)  {
            p = n;
            n = n.Next;
        }

        if (index > 0) { 
            throw new AKSoft.DataStructures.Core.Exception.InvalidArgumentException("INDEX_OUT_OF_BOUND"); 
        }

        var node = new Node() { Data = data };

        if (p == null) {
            Head = node;            
        } else {
            p.Next = node;
        }

        node.Next = n;
        return;
    }

    public void Clear() {
        Head = null;
    }

    public void Remove(T data) {

        var n = Head;
        Node p = null;
        while(n != null) {
            if (n.Data.Equals(data)) {

                if (Head == n) {
                    Clear();
                } else {
                    p.Next = n.Next;
                }

                break;
            }

            p = n;
            n = n.Next;
        }
    }

    public int Count() {
        var i = 0;
        var n = Head; 
        while(n != null) { i++; n = n.Next; }
        return i;
    }

    public void Print() {
        var n = Head;
        while(n != null) {
            Console.Write($"{n.Data},");
            n = n.Next;
        }
        Console.WriteLine(""); 
    }
}