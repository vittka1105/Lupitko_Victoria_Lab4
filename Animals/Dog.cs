using System;


namespace Animals
{
    public class Dog : Animal
    {
        public Dog(int age) : base(age)
        {
            Speed = 10;
        }

        public override void GetVoice()
        {
            Console.WriteLine("Гав-гав");
        }

        public override string ToString()
        {
            return "Собака";
        }
    }
}
