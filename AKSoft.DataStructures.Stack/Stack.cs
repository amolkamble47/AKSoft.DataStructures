// Author: Amol Kamble 
// AKSoft.INC (c) copyright 2024

namespace AKSoft.DataStructures.Stack;

using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using AKSoft.DataStructures.Core.Exception;

public class Stack<T>  {

    T?[] arr;
    int pointer = -1;

    public Stack(int size) {
        arr = new T[size];
    }

    public int Length { get => arr.Length; }

    public int ItemsCount { get => pointer + 1; }

    public T?[] Array { get => arr; }
    public int Pointer { 
        get { return pointer; } 
        private set { pointer = value; } 
    }

    public void Clear() {
        while(!IsEmpty()) Pop();
    }

    public bool IsFull() {
        return pointer >= arr.Length - 1;
    }

    public bool IsEmpty() {
        return pointer < 0;
    }

    public void Push(T? i) {
        if (IsFull()) {
            throw new FullException("STACK_FULL");
        }
        
        ++pointer;
        arr[pointer] = i;  
    }

    public T? Pick() {
        return arr[pointer];
    }

    public T? Pop() {
        if (IsEmpty()) {
            throw new EmptyException("STACK_EMPTY");
        }
        T? tmp = arr[pointer];
        arr[pointer] = default(T);
        pointer--;
        return tmp;
    }
}
