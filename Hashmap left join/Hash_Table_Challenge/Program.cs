using Trees;

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

            //string lowers = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t " +
            //                "know what I was doing in New York...";
            //string[] words = lowers.Split(' ', ',');
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}
            //Console.WriteLine(HashTable.RepeatedWord("Once upon a time, there was a brave princess who..."));
            //Console.WriteLine(HashTable.RepeatedWord("It was the best of times, it was the worst of times, it was the " +
            //          "age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of" +
            //          " incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope," +
            //          " it was the winter of despair, we had everything before us, we had nothing before us, " +
            //          "we were all going direct to Heaven, we were all going direct the other way – in short, " +
            //          "the period was so far like the present period, that some of its noisiest authorities insisted on " +
            //          "its being received, for good or for evil, in the superlative degree of comparison only..."));
            //Console.WriteLine(HashTable.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the " +
            //    "Rosenbergs, and I didn’t know what I was doing in New York..."));

            //BinaryTree binaryTree = new BinaryTree();
            //binaryTree.Root = new TreeNode(1);
            //binaryTree.Root.left = new TreeNode(7);
            //binaryTree.Root.right = new TreeNode(5);
            //binaryTree.Root.left.left = new TreeNode(9);
            //binaryTree.Root.left.right = new TreeNode(6);
            //binaryTree.Root.left.right.left = new TreeNode(3);
            //binaryTree.Root.left.right.right = new TreeNode(11);
            //binaryTree.Root.right.right = new TreeNode(10);
            //binaryTree.Root.right.right.left = new TreeNode(4);

            //BinaryTree binaryTree2 = new BinaryTree();
            //binaryTree2.Root = new TreeNode(2);
            //binaryTree2.Root.left = new TreeNode(7);
            //binaryTree2.Root.right = new TreeNode(5);
            //binaryTree2.Root.left.left = new TreeNode(2);
            //binaryTree2.Root.left.right = new TreeNode(6);
            //binaryTree2.Root.left.right.left = new TreeNode(17);
            //binaryTree2.Root.left.right.right = new TreeNode(11);
            //binaryTree2.Root.right.right = new TreeNode(10);
            //binaryTree2.Root.right.right.left = new TreeNode(4);

            //TreeIntersection.Tree_Intersection(binaryTree, binaryTree2).ForEach(Console.WriteLine);

            HashTable synonyms = new HashTable();
            synonyms.Set("diligent", "employed");
            synonyms.Set("fond", "enamored");
            synonyms.Set("guide", "usher");
            synonyms.Set("outfit", "garb");
            synonyms.Set("wrath", "anger");

            HashTable antonyms = new HashTable();
            antonyms.Set("diligent", "idle");
            antonyms.Set("fond", "averse");
            antonyms.Set("guide", "follow");
            antonyms.Set("flow", "jam");
            antonyms.Set("wrath", "delight");

            HashTable.LeftJoin(synonyms, antonyms).ForEach(Console.WriteLine);
        }
    }
}