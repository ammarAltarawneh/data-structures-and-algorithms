namespace Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchClass<int> binarySearchClass = new BinarySearchClass<int>();

            binarySearchClass.Add(50);
            binarySearchClass.Add(30);
            binarySearchClass.Add(70);
            binarySearchClass.Add(20);
            binarySearchClass.Add(40);
            binarySearchClass.Add(60);
            binarySearchClass.Add(80);


            Console.WriteLine("Pre-Order Traversal");

            string resultString = string.Join(",", binarySearchClass.PreOrderTravarsel());
            Console.WriteLine(resultString);


            Console.WriteLine("In-order Traversal");
            Console.WriteLine(string.Join(", ", binarySearchClass.InorderTraversal()));

            Console.WriteLine("Post-order Traversal");
            Console.WriteLine(string.Join(", ", binarySearchClass.PostorderTraversal()));

            // Check if values exist in the binary search tree
            Console.WriteLine("Contains 5: " + binarySearchClass.Contains(5));
            Console.WriteLine("Contains 20: " + binarySearchClass.Contains(20));
        }
    }
}