using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    /// <summary>
    /// This class with represents the base elements on an enemy.
    /// </summary>
    public class Enemy
    {
        /// <summary>
        /// The health of the enemy
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// The name of the enemy
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This determines if the enemy is dead.
        /// </summary>
        public bool IsDead { get; set; }

        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="name">The name we want to give to this enemy!</param>
        public Enemy(string name)
        {
            // Set the health to 100.
            Health = 100;
            //Set the enemy name:
            Name = name;
        }

        /// <summary>
        /// This gets called when the enemy is hit.
        /// </summary>
        /// <param name="hit_values">The amount of value the enemy will take</param>
        public void GetsHit(int hit_values)
        {
            //Subtract the hit value from the Health
            Health = Health - hit_values;

            //Show the enemy has been hit
            Console.WriteLine(Name + ", has been hit with " + hit_values + " Damages!. He now has " + Health+ " remaining.");

            //Check if the enemy is dead
            if (Health <= 0)
            {
                // The enemy is dead
                Die();
            }
        }

        /// <summary>
        /// This method is called when the function is supposed to die.
        /// </summary>
        private void Die()
        {
            //Write to the console the enemy has died
            Console.WriteLine(Name + ", Has Died!");

            //Set the boolean it is true
            IsDead = true;
        }
    }
}
