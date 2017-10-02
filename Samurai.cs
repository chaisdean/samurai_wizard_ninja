namespace wizard_samurai
{
    public class samurai: human
    {
        public samurai(string i): base(i)
        {
            strength = 200;
        }

        public void death_blow(object enemy)
        {   
            human opponent = enemy as human;
            if(enemy != null)
            {
                if(opponent.health < 50)
                {
                    opponent.health = 0;
                }
            }
        }

        public void meditate()
        {
            health = 200;
        }
    }
}