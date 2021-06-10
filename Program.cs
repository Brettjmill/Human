using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Joe Default");
            Human human2 = new Human("Chad Nondefault", 10, 10, 10, 200);

            Console.WriteLine(human2.CurrentHealth);
            human1.Attack(human2);
            Console.WriteLine(human2.CurrentHealth);
            Console.WriteLine(human1.CurrentHealth);
            human2.Attack(human1);
            Console.WriteLine(human1.CurrentHealth);
        }
    }
}
