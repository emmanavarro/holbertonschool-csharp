using System;

namespace Enemies
{
    /// <summary>This class create a Zombie.</summary>
    public class Zombie
    {
        /// <summary>Private field that defines the zombie's health.</summary>
        private int health;

        /// <summary>Private field that defines the zombie's name.</summary>
        private string name = "(No name)";

        /// <summary>Public property that gets and sets the zombie's name.</summary>
        public string Name
        {
            get => name ;
            set => name = value;
        }

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

        /// <summary>Public method that returns the value of health of the Zombie object.</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
