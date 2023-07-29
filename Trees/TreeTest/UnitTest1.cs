using Trees;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();

            // Assert
            Assert.Null(bst.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRootNode()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();
            bst.Add(10);

            // Assert
            Assert.NotNull(bst.Root);
            Assert.Equal(10, bst.Root.Value);
        }

        [Fact]
        public void CanAddLeftAndRightChildrenToNode()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Assert
            Assert.Equal(5, bst.Root.Left.Value);
            Assert.Equal(15, bst.Root.Right.Value);
        }

        [Fact]
        public void CanPerformPreorderTraversal()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(8);
            bst.Add(12);
            bst.Add(18);

            // Act
            var result = bst.PreOrderTravarsel();

            // Assert
            Assert.Equal(new int[] { 10, 5, 3, 8, 15, 12, 18 }, result);
        }

        [Fact]
        public void CanPerformInorderTraversal()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(8);
            bst.Add(12);
            bst.Add(18);

            // Act
            var result = bst.InorderTraversal();

            // Assert
            Assert.Equal(new int[] { 3, 5, 8, 10, 12, 15, 18 }, result);
        }

        [Fact]
        public void CanPerformPostorderTraversal()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(8);
            bst.Add(12);
            bst.Add(18);

            // Act
            var result = bst.PostorderTraversal();

            // Assert
            Assert.Equal(new int[] { 3, 8, 5, 12, 18, 15, 10 }, result);
        }

        [Fact]
        public void CanCheckValueExistenceInTree()
        {
            // Arrange
            var bst = new BinarySearchClass<int>();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(3);
            bst.Add(8);
            bst.Add(12);
            bst.Add(18);

            // Act & Assert
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
            Assert.True(bst.Contains(3));
            Assert.True(bst.Contains(8));
            Assert.True(bst.Contains(12));
            Assert.True(bst.Contains(18));

            Assert.False(bst.Contains(20));
            Assert.False(bst.Contains(6));
        }
    }
}