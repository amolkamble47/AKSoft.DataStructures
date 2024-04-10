
namespace AKSoft.DataStructures.Test;

using Xunit.Sdk;
using AKSoft.DataStructures.Core.Exception;
using AKSoft.DataStructures.LinkedList;
using System.Security.Cryptography;

public class TestData : IDisposable  {

    public TestData() {
        List = new LinkedList<int>();
    }

    public LinkedList<int> List { get; set;}

    private void Dispose(bool disposing) {
        if (disposing) {
            // unmanaged code
            // file handles
            // or any other system resources
        }

        // dispose managed code
    }

    public void Dispose() {
        Dispose(true);
    }
}

public class LinkedListTests : IClassFixture<TestData> {

    public TestData Fixture { get; set; }

    public LinkedListTests(TestData fixture) {
        this.Fixture = fixture;
    }

    [Fact]
    public void AddItem() {
        this.Fixture.List.Clear();
        this.Fixture.List.Add(1);
        Assert.Equal(1, this.Fixture.List.Count());
        this.Fixture.List.Add(2);
        this.Fixture.List.Add(3);
        Assert.Equal(3, this.Fixture.List.Count());
    }

    [Fact]
    public void RemoveItem() {
        this.Fixture.List.Clear();
        this.Fixture.List.Add(1);
        Assert.Equal(1, this.Fixture.List.Count());
        this.Fixture.List.Add(2);
        this.Fixture.List.Add(3);        
        Assert.Equal(3, this.Fixture.List.Count());
        this.Fixture.List.Remove(2);
        Assert.Equal(2, this.Fixture.List.Count());
        this.Fixture.List.Remove(3);
        Assert.Equal(1, this.Fixture.List.Count());
        this.Fixture.List.Remove(1);
        Assert.Equal(0, this.Fixture.List.Count());
    }

}