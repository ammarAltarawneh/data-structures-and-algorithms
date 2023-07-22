namespace Stack_Queue_Pseudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our project");

            PseudoQueue queue = new PseudoQueue();

            // Enqueue elements
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            // Peek the front element
            Console.WriteLine("Peek: " + queue.Peek());

            // Dequeue an element
            queue.Dequeue();

            // Peek again
            Console.WriteLine("Peek: " + queue.Peek());

            // Dequeue all elements
            queue.Dequeue();
            queue.Dequeue();


        }
    }
}