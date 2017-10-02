using System;

namespace wizard_samurai
{
    public class human
    {
        public string name;
        public int strength {get ; set;}
        public int health {get ; set;}
        public int intelligence { get; set;}
        public int dexterity {get; set;}

        public human(string name, int str, int helth, int intel, int dex)
        {
            strength = str;
            health = helth;
            intelligence = intel;
            dexterity = dex;
        }

        public human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public void attack(object obj)
        {
            human enemy = obj as human;
            if(enemy == null)
            {
                Console.WriteLine("Missed!");
            }
            else{
                enemy.health -= 5 * strength;
            }
        }
    }
}