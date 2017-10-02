namespace wizard_samurai
{
    public class ninja : human
    {
        public ninja(string i) : base(i)
        {
            dexterity = 175;
        }

        public void steal(object enemy)
        {
            human opponent = enemy as human;
            if(opponent != null)
            {
                health+= 10;
                attack(opponent);
            }
        }

        public void run_away()
        {
            health -= 15;
        }
    }
}