using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using static Program;

namespace SLLTests;

public class UnitTest1
{

    [Fact]
    public void EmptyList()
    {
        SinglyLinkedList sll = new SinglyLinkedList();

        Assert.Null(sll.head);

    }

    [Fact]
    public void InsertToHead_CanInsert()
    {
        SinglyLinkedList sll = new SinglyLinkedList();

        sll.InsertToHead(5);

        Assert.Equal(sll.head.data, 5);
    }


    [Fact]
    public void HeadProperty_PointsToFirstNode()
    {
        SinglyLinkedList sll = new SinglyLinkedList();
        sll.InsertToHead(1);
        sll.InsertToHead(3);
        sll.InsertToHead(6);

        Assert.Equal(sll.head.data, 6);

    }


    [Fact]
    public void InsertToHead_InsertMultipleNodes()
    {       
        SinglyLinkedList sll = new SinglyLinkedList();
       
        sll.InsertToHead(2);
        sll.InsertToHead(4);
        sll.InsertToHead(8);

        Assert.Equal("{ 8 } -> { 4 } -> { 2 } -> NULL", sll.ToString());
    }



    [Fact]
    public void Includes_ReturnTrueIfExists()
    {
        SinglyLinkedList sll = new SinglyLinkedList();

        sll.InsertToHead(2);
        sll.InsertToHead(4);
        sll.InsertToHead(8);

        Assert.Equal(sll.Includes(4), true);
    }

   
    [Fact]
    public void Includes_ReturnFalseIfNotExists()
    {

        SinglyLinkedList sll = new SinglyLinkedList();

        sll.InsertToHead(2);
        sll.InsertToHead(4);
        sll.InsertToHead(8);

        Assert.Equal(sll.Includes(6), false);

    }












}
