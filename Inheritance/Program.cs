using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done a class Animal
            // give this class 4 members that all Animals have in common


            //Done Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Done a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Done Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.CanFly = true;
            myBird.BeakLengthInInches = 13;
            myBird.Color = "White";
            myBird.DoMigrate = true;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptile()
            {
                IsColdBlooded = true,
                CanGrowTail = true,
                HasScales = true,
                Habitat = "swamp"
            };

            var myAnimals = new Animal[] { myBird, alligator };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Breed: {animal.Breed}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Name: {animal.Name}");
            }
        }
    }
}
