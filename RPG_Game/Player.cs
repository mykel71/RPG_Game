using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    /// <summary>
    /// This Class represents playable characters.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// This represents the players Health.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// The name of the player.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This determines if the player is dead.
        /// </summary>
        public bool IsDead { get; set; }

        /// <summary>
        /// Determines if the player is really guarding
        /// </summary>
        public bool IsGuarding { get; set; }

        /// <summary>
        /// The Default Constructor.
        /// </summary>

        public Player()
        {
            // Set the default Health values to 100
            Health = 100;
        }

        /// <summary>
        /// This gets called when the enemy is hit.
        /// </summary>
        /// <param name="hit_values">The amount of value the player will take</param>
        public void GetsHit(int hit_values)
        {

            if (IsGuarding)
            {
                //Show player defended
                Console.WriteLine(Name + ", Guarded the Blow and was unharmed!");

                //remove the shield
                IsGuarding = false;
            }
            else
            {
                //Subtract the hit value from the Health
                Health = Health - hit_values;

                //Show the player has been hit
                Console.WriteLine(Name + ", you have been hit with " + hit_values + " Damages!. You now have " + Health + " remaining.");
            }
            
           

            //Check if the player is dead
            if (Health <= 0)
            {
                // The player is dead
                Die();
            }
        }

        private void Die()
        {
            //Write to the console the player has died
            Console.WriteLine(Name + ", You Lose!");

            //Set the boolean it is true
            IsDead = true;
        }

        /// <summary>
        /// Heals the player with amount to heal
        /// </summary>
        /// <param name="amount_to_heal">The number amount to Heal</param>
        public void Heal(int amount_to_heal)
        {
            //Heal the player by adding the amount to heal with health
            Health = (Health + amount_to_heal) > 100 ? 100 : (Health + amount_to_heal);

            //Let the player know he has healed
            Console.WriteLine(Name + ", has healed " + amount_to_heal + "health. You now have " + Health + " remaining!");
        }
    }
}
