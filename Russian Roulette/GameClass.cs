using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roulette
{
   public class GameClass
    {
       public int bullet;
        public int shot;
        public int go = 7;
       public int away = 1;
        public string Player;
        public int Score = 10;

        public int Rand_number()
        {
            // Random Bullet 1 - 6
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
