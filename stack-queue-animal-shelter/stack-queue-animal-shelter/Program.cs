namespace stack_queue_animal_shelter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Queue queue = new Queue();
            //queue.Enqueue("1");
            //queue.Enqueue("2");
            //queue.Enqueue("3");
            //Console.WriteLine(queue.ToString());
            //queue.Dequeue();
            //Console.WriteLine(queue.ToString());

            //PseudoQueue pseudoQueue = new PseudoQueue();
            //pseudoQueue.Enqueue("1");
            //pseudoQueue.Enqueue("2");
            //pseudoQueue.Enqueue("3");
            //pseudoQueue.Enqueue("4");
            //pseudoQueue.Dequeue();

            AnimalShelter animalShelter = new AnimalShelter();
        Animal cat = new Cat();
        cat.Name = "Fluffy";
        animalShelter.Enqueue(new Dog() { Name = "Buddy" });
        animalShelter.Enqueue(new Dog() { Name = "Max" });
        animalShelter.Enqueue(cat);
        animalShelter.Enqueue(cat);
        animalShelter.Enqueue(cat);

        Console.WriteLine(animalShelter.Dequeue("dog")); // Output: Buddy
        Console.WriteLine(animalShelter.Dequeue("cat")); // Output: Fluffy
        Console.WriteLine(animalShelter.Dequeue("dog")); // Output: null (No more dogs in the queue)
        Console.WriteLine(animalShelter.Dequeue("cat")); // Output:  Fluffy
        }
    }
}