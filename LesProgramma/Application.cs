using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProgramma
{
    class Application
    {
        static bool open = true;

        static int Main(string[] args)
        {
            Player player = new Player(Vector3.Zero);
            player.Awake();

            while (open)
            {
                player.Update();
                Console.WriteLine("Player Position: " + player.position.x + ", " + player.position.y + ", " + player.position.z);
                Console.WriteLine("Player Health: " + player.Health + "\n");
            }

            return 0;
        }
    }
}
