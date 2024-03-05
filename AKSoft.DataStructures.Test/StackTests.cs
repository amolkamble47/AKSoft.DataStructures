
namespace AKSoft.DataStructures.Test;

using Xunit.Sdk;
using AKSoft.DataStructures.Core.Exception;
using AKSoft.DataStructures.Stack;


public class StackTests
{

    AKSoft.DataStructures.Stack.Stack<int> stk;
    public StackTests() {
        stk = new AKSoft.DataStructures.Stack.Stack<int>(10);
    }

    [Fact]
    public void StackSizeTest() {
        Assert.True(10 == stk.Length);
    }

    [Fact]
    public void StackPushTest() {
        stk.Clear();
        stk.Push(1);
        Assert.Equal(1, stk.ItemsCount);
    }

    [Fact]
    public void StackPushPopTest1() {
        stk.Clear();
        stk.Push(1);
        stk.Push(2);
        stk.Push(33);
        Assert.Equal(33, stk.Pop());
    }

    [Fact]
    public void StackFullExceptionTest1() {
       stk.Clear();
       while (!stk.IsFull()) stk.Push(0);
       Assert.ThrowsAny<AKSoft.DataStructures.Core.Exception.FullException>(() => stk.Push(1));
    }

    [Fact]
    public void StackEmptyExceptionTest1() {
        stk.Clear();
        Assert.ThrowsAny<AKSoft.DataStructures.Core.Exception.EmptyException>(() => stk.Pop());
    }
}
