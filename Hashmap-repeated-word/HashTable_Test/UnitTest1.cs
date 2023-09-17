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

        //RepeatedWordTest
        [Fact]
        public void TestRepeatedWordSimple()
        {
            Assert.Equal("a", HashTable.RepeatedWord("Once upon a time, there was a brave princess who..."));
        }

        [Fact]
        public void TestRepeatedWordSmallLetters()
        {
            Assert.Equal("it", HashTable.RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way  in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
        }

        [Fact]
        public void TestRepeatedWordComa()
        {
            Assert.Equal("summer", HashTable.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didnt know what I was doing in New York..."));
        }
    }
}