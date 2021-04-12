using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProgramma
{
    // Inherited from class <see cref="Base"/>.
    class Player : Object
    {
        /// Property, just to let you know of their existence ;) <see cref="Vector3"/> for better implementation usecase.
        public int Health { get; private set; } = 0;

        /// Constructor inherits from class <see cref="Object"/>, base needs a position input, this must be passed by the player constructor.
        public Player(Vector3 position) : base(position) { }

        public override void Awake()
        {
            Console.WriteLine("Player initialized.");
        }

        public override void Update()
        {
            Console.WriteLine("Player update.");
            position = position + new Vector3(0, 1, 2);
            Heal();
            Heal(10);
            // Total health += 20 each loop.
        }

        // Can be overriden in a child class with "protected override void Heal(){}"
        protected virtual void Heal()
        {
            Health -= 10;
        }

        // Overloaded method.
        public void Heal(int value)
        {
            Health -= 10;
        }
    }
}
