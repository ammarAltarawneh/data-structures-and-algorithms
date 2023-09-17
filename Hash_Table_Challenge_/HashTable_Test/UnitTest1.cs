using Hash_Table_Challenge;

namespace HashTable_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestHashTableSet()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");

            Assert.True(hashTable.Has("Luffy"));
        }

        [Fact]
        public void TestHashTableGet()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");

            Assert.Equal("One Piece", hashTable.Get("Luffy"));
        }

        [Fact]
        public void TestHashTableNull()
        {
            HashTable hashTable = new HashTable();

            Assert.Null(hashTable.Get("Goku"));
        }

        [Fact]
        public void TestHashTableList()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");
            hashTable.Set("Goku", "Dragon Ball");
            hashTable.Set("Gon", "Hunter X Hunter");

            List<string> list = new List<string>();
            list.Add("Gon");
            list.Add("Goku");
            list.Add("Luffy");

            Assert.Equal(list, hashTable.Keys());
        }

        [Fact]
        public void TestHashTableCollision()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");
            hashTable.Set("yffuL", "Straw Hat");

            Assert.Equal(hashTable.Hash("Luffy"), hashTable.Hash("yffuL"));
            Assert.True(hashTable.Has("Luffy"));
            Assert.True(hashTable.Has("yffuL"));
        }

        [Fact]
        public void TestHashTableCollisionValue()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("Luffy", "One Piece");
            hashTable.Set("yffuL", "Straw Hat");

            Assert.Equal("Straw Hat", hashTable.Get("yffuL"));
        }

        [Fact]
        public void TestHashTableHashInRange()
        {
            HashTable hashTable = new HashTable();

            Assert.True(hashTable.Hash("ABCDEFGHIJKLMNOP") > 0);
            Assert.True(hashTable.Hash("ABCDEFGHIJKLMNOP") < 1024);
        }
    }
}