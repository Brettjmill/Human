using System;

namespace Human{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int CurrentHealth
        {
            get { return health; }
        }
        public Human(string inputName)
        {
            Name = inputName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string inputName, int inputStrength, int inputIntelligence, int inputDexterity, int inputHealth)
        {
            Name = inputName;
            Strength = inputStrength;
            Intelligence = inputIntelligence;
            Dexterity = inputDexterity;
            health = inputHealth;
        }

        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.health -= damage;
            return target.health;
        }
    }
}

