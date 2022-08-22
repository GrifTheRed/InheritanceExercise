using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            Breed = "Pelican";
            Age = 4;
            Name = "Steve";
        }

        public string Color { get; set; }
        public bool CanFly { get; set; }
        public bool DoMigrate { get; set; }
        public double BeakLengthInInches { get; set; }
    }
}

