using System;

namespace myObjects
{
    class Hero
    {
        public string name;
        public int strength;
        public int speed;

        public Hero(string name)
        {
            this.name = name;
            strength = 100;
            speed = 50;
        }
        public void eatFood(string food)
        {
            if (food == "good")
            {
                strength = strength + 50;
            }
            else if (food == "bad")
            {
                strength = strength - 50;
            }
        }
    }

    static class HeroGenerator
    {
        static public Hero CreateHero(this string name)
        {
            return new Hero(name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hero H = new Hero("Hrun");
            Console.WriteLine(H.name);
            Hero H2 = "Perseus".CreateHero();
            Console.WriteLine(H2.name);
        }
    }
}
