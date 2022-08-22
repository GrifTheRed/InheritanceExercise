using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Name = "Steven";
            Breed = "Ammerican Alligator";
            Age = 30;
        }

        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}

