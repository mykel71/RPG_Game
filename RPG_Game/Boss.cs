using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    /// <summary>
    /// The Boss Properties
    /// </summary>
    public class Boss : Enemy
    {
        /// <summary>
        /// Set the default constructor
        /// </summary>
        public Boss() : base("Big Boss")
        {
            // Set the health to a higher value:
            Health = 150;
        }
    }
}
