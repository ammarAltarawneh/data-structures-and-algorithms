namespace Hash_Table_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable hash = new HashTable();
            //hash.Set("Goku", "Dragon Ball");
            //hash.Set("Luffy", "One Piece");
            //Console.WriteLine(hash.Get("Goku"));
            //Console.WriteLine(hash.Get("Luffy"));
            //Console.WriteLine(hash.Get("s"));
            //Console.WriteLine(hash.Has("Luffy"));
            //Console.WriteLine(hash.Has("s"));

            //Console.WriteLine("{0}", String.Join(", ", hash.Keys()));

            string lowers = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t " +
                            "know what I was doing in New York...";
            string[] words = lowers.Split(' ', ',');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine(HashTable.RepeatedWord("Once upon a time, there was a brave princess who..."));
            Console.WriteLine(HashTable.RepeatedWord("It was the best of times, it was the worst of times, it was the " +
                      "age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of" +
                      " incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope," +
                      " it was the winter of despair, we had everything before us, we had nothing before us, " +
                      "we were all going direct to Heaven, we were all going direct the other way – in short, " +
                      "the period was so far like the present period, that some of its noisiest authorities insisted on " +
                      "its being received, for good or for evil, in the superlative degree of comparison only..."));
            Console.WriteLine(HashTable.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the " +
                "Rosenbergs, and I didn’t know what I was doing in New York..."));


        }
    }
}