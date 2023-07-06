using LinkedList_zip;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace LinkedList_zip_Test
{
    public class UnitTest1
    {
        [Fact]
        public void ZipListsShouldZipTwoLinkedLists()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);

            LinkedList list2 = new LinkedList();
            list2.Append(5);
            list2.Append(9);
            list2.Append(4);

            // Act
            Node result = LinkedList.ZipLists(list1, list2);

            // Assert
            Assert.Equal(1, result.Data);
            Assert.Equal(5, result.Next.Data);
            Assert.Equal(3, result.Next.Next.Data);
            Assert.Equal(9, result.Next.Next.Next.Data);
            Assert.Equal(2, result.Next.Next.Next.Next.Data);
            Assert.Equal(4, result.Next.Next.Next.Next.Next.Data);
            Assert.Null(result.Next.Next.Next.Next.Next.Next);
        }

        
    }
}