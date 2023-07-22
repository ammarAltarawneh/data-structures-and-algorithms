using stack_queue_animal_shelter;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Dequeue_ReturnsCorrectDogName()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Dog() { Name = "Buddy" });
            animalShelter.Enqueue(new Dog() { Name = "Max" });
            Animal cat = new Cat();
            cat.Name = "Fluffy";
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(cat);

            // Act
            string dogName = animalShelter.Dequeue("dog");

            // Assert
            Assert.Equal("Buddy", dogName);
        }

        [Fact]
        public void Dequeue_ReturnsCorrectCatName()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Dog() { Name = "Buddy" });
            animalShelter.Enqueue(new Dog() { Name = "Max" });
            Animal cat = new Cat();
            cat.Name = "Fluffy";
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(cat);

            // Act
            string catName = animalShelter.Dequeue("cat");

            // Assert
            Assert.Equal("Fluffy", catName);
        }

        [Fact]
        public void Dequeue_ReturnsNullForNoMoreDogs()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter();
            animalShelter.Enqueue(new Dog() { Name = "Buddy" });
            animalShelter.Enqueue(new Dog() { Name = "Max" });
            Animal cat = new Cat();
            cat.Name = "Fluffy";
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(cat);
            animalShelter.Enqueue(cat);

            // Act
            animalShelter.Dequeue("dog"); // Dequeue the first dog
            animalShelter.Dequeue("dog"); // Dequeue the second dog
            string dogName = animalShelter.Dequeue("dog"); // Try to dequeue a dog again

            // Assert
            Assert.Null(dogName);
        }

        
    }
}