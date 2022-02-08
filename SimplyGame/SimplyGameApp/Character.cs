namespace SimplyGameApp // Note: actual namespace depends on the project name.
{
    public class Character : Values
    {
        public string Name;
        public int Hp;
        public int Exp;

        public Character()
        {
            Hp = 100;
            Exp = 0;
        }

        public int Move(int stepsCount)
        {
            if (stepsCount > 0)
            {
                discance += stepsCount;
            }
            return discance;
        }
    }
}