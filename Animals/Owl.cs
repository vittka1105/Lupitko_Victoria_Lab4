using System;


namespace Animals
{
    public class Owl : Bird
    {
        public Owl(int age) : base(age, 20)
        {
            Speed = 30;
        }

        public override void GetVoice()
        {
            Console.WriteLine("Угу-угу");
        }

        public override string ToString()
        {
            return "Сова";
        }
    }
}
