using AKSoft.DataStructures.Core.Exception;

namespace AKSoft.DataStructures.Queue;

public class Queue<T>
{
    T?[] arr;
    int head = -1;
    int tail = -1;

    public Queue(int size) {
        arr = new T[size];
    }

    public int Length { get => arr.Length; }

    public int ItemsCount { get 
        => IsEmpty() ? 0 
        : IsFull() ? Length 
        : Math.Abs(tail - head) + 1;
     }

    public T?[] Array { get => arr; }


    public void Clear() {
        while(!IsEmpty()) Dequeue();
    }

    public bool IsFull() {
        return (tail + 1) % (Length) == head;
    }

    public bool IsEmpty() {
        return head < 0 && tail < 0;
    }

    public void Enqueue(T? i) {

        if (IsFull()) {
            throw new FullException("QUEUE_FULL");
        }

        if (tail == -1) { //first item
            head = tail = 0;
        } else {
            tail = (tail + 1) % (Length);
        }

        arr[tail] = i;
    }

    public T? Pick() {
        return arr[head];
    }

    public T? Dequeue() {
        if (IsEmpty()) {
            throw new EmptyException("QUEUE_EMPTY");
        }

        T? tmp = arr[head];
        arr[head] = default(T);

        if (head == tail) { // last item
            head = tail = -1;
        } else {
            head =  (head + 1) % (Length);
        }

        return tmp;
    }
}
