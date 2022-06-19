using System;


namespace Animals
{
    public abstract class Animal
    {
        protected int Age;
        protected int Speed;

        protected Animal(int age)
        {
            Age = age;
        }

        public abstract void GetVoice();

        public void ShowSpeedMovement()
        {
            Console.WriteLine($"Швидкість - {ToString()} " + Speed);
        }
    }
}
