
namespace AKSoft.DataStructures.Test;

using Xunit.Sdk;
using AKSoft.DataStructures.Core.Exception;
using AKSoft.DataStructures.Queue;


public class QueueTests
{

    AKSoft.DataStructures.Queue.Queue<int> q;
    public QueueTests() {
        q = new AKSoft.DataStructures.Queue.Queue<int>(4);
    }

    [Fact]
    public void QueueSizeTest() {
        Assert.True(4 == q.Length);
    }

    [Fact]
    public void QueuePushTest() {
        q.Clear();
        q.Enqueue(1);
        q.Enqueue(3);
        Assert.Equal(2, q.ItemsCount);
    }

    [Fact]
    public void QueuePushPopTest1() {
        q.Clear();
        q.Enqueue(11);
        q.Enqueue(2);
        q.Enqueue(33);
        Assert.Equal(11, q.Dequeue());
    }

    [Fact]
    public void QueuePushPopTest2() {
        q.Clear();
        q.Enqueue(11);
        q.Enqueue(2);
        q.Enqueue(33);
        q.Enqueue(44);
        Assert.Equal(11, q.Dequeue());
        Assert.Equal(2, q.Dequeue());
        q.Enqueue(55);
        Assert.Equal(33, q.Dequeue());
        Assert.Equal(44, q.Dequeue());
        Assert.Equal(55, q.Dequeue());
    }

    [Fact]
    public void QueueFullExceptionTest1() {
       q.Clear();
       while (!q.IsFull()) q.Enqueue(0);
       Assert.ThrowsAny<AKSoft.DataStructures.Core.Exception.FullException>(() => q.Enqueue(1));
    }

    [Fact]
    public void QueueEmptyExceptionTest1() {
        q.Clear();
        Assert.ThrowsAny<AKSoft.DataStructures.Core.Exception.EmptyException>(() => q.Dequeue());
    }
}
