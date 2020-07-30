using System;

namespace Enemies
{

/// <summary>
/// Represents a Zombie
/// </summary>
    public class Zombie
    {
        /* Represents the health */
        int health;
        /* Represesnts the name */
        string name = "(No Name)";

        /// <summary>
        /// Initializes a new instance of Zombie
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of Zombie
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        
        /// <summary>
        /// Returns the value of health
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Gets and sets the name.
        /// </summary>
        /// <value></value>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}