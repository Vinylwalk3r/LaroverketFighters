using System;

namespace Program
{
    public class Enemy
    {
        public int hp, dmg;
        public string name;

        public void Setup()
        {
            Random randomness = new Random();

            hp = randomness.Next(10, 200);

            dmg = randomness.Next(12, 18);

            name = "Kenzykatz";
        }
    }
}
