using System;
using System.Collections.Generic;

namespace wizard_samurai
{
    public class wizard : human
    {
        public wizard(string i) : base(i)
        {
            health = 50;
            intelligence = 25;
        }

        public void heal(object self)
        {
            health = 10 * intelligence;
        }

        public void fireball(object enemy)
        {
            human opponent = enemy as human;
            Random rand = new Random();
            int attackrand = rand.Next(20,51);
            if(opponent != null)
            {
                opponent.health -= attackrand;
            }
        }
    }
    
}