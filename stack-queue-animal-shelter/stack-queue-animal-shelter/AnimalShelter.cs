using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_animal_shelter
{
    public class AnimalShelter
    {
        Queue<Animal> animals = new Queue<Animal>();

        public void Enqueue(Animal animal)
        {
            animals.Enqueue(animal);
        }

        public string Dequeue(string pref)
        {
            Queue<Animal> tempQueue = new Queue<Animal>();

            while (animals.Count > 0)
            {
                var animal = animals.Dequeue();
                if (animal.Species == pref)
                {
                    return animal.Name;
                }
                tempQueue.Enqueue(animal);
            }

            while (tempQueue.Count > 0)
            {
                animals.Enqueue(tempQueue.Dequeue());
            }

            return null;
        }
    }

    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            Species = "cat";
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Species = "dog";
        }
    }
}
