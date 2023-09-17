namespace Hash_Table_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable hash = new HashTable();
            hash.Set("Goku", "Dragon Ball");
            hash.Set("Luffy", "One Piece");
            Console.WriteLine(hash.Get("Goku"));
            Console.WriteLine(hash.Get("Luffy"));
            Console.WriteLine(hash.Get("s"));
            Console.WriteLine(hash.Has("Luffy"));
            Console.WriteLine(hash.Has("s"));

            Console.WriteLine("{0}", String.Join(", ", hash.Keys()));
        }
    }
}