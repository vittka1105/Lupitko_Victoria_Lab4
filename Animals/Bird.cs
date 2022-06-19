using System;


namespace Animals
{
    public class Bird : Animal
    {
        private int _maxHeight;

        public Bird(int age, int maxHeight) : base(age)
        {
            _maxHeight = maxHeight;
            Speed = 15;
        }

        public override void GetVoice()
        {
            Console.WriteLine("Кар-кар");
        }

        public void ShowMaxHeightOfFlight()
        {
            Console.WriteLine($"Максимальна висота {ToString()}: " + _maxHeight);
        }

        public override string ToString()
        {
            return "Пташка";
        }
    }
}
