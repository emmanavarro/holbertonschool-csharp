using System;

namespace Enemies
{
    /// <summary>This class create a Zombie.</summary>
    public class Zombie
    {
        /// <summary>Public field that defines the zombie's health.</summary>
        public int health;

        /// <summary>Public constructor, initializes a new instance of Zombie class.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Public constructor, initializes a new instance of Zombie class and checks if value is greater than 0.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}
