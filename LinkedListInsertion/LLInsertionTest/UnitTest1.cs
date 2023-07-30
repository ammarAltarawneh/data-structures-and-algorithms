using LinkedListInsertion;

namespace LLInsertionTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddNodeToFront()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();

            // Act
            list.AddNodeToFront(1);
            list.AddNodeToFront(2);
            list.AddNodeToFront(3);

            // Assert
            Assert.Equal("3 -> 2 -> 1 -> NULL", list.StringifyLinkedList());
        }

        [Fact]
        public void TestExistInLinkedList()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddNodeToFront(1);
            list.AddNodeToFront(2);
            list.AddNodeToFront(3);

            // Assert
            Assert.True(list.ExistInLinkedList(2));
            Assert.False(list.ExistInLinkedList(4));
        }

        [Fact]
        public void TestAppend()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddNodeToFront(1);
            list.AddNodeToFront(2);
            list.AddNodeToFront(3);

            // Act
            list.Append(4);

            // Assert
            Assert.Equal("3 -> 2 -> 1 -> 4 -> NULL", list.StringifyLinkedList());
        }

        [Fact]
        public void TestInsertBefore()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddNodeToFront(1);
            list.AddNodeToFront(2);
            list.AddNodeToFront(3);

            // Act
            list.InsertBefore(2, 4);

            // Assert
            Assert.Equal("3 -> 4 -> 2 -> 1 -> NULL", list.StringifyLinkedList());
        }

        [Fact]
        public void TestInsertAfter()
        {
            // Arrange
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddNodeToFront(1);
            list.AddNodeToFront(2);
            list.AddNodeToFront(3);

            // Act
            list.InsertAfter(2, 4);

            // Assert
            Assert.Equal("3 -> 2 -> 4 -> 1 -> NULL", list.StringifyLinkedList());
        }
    }
}