using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(20, 50);
            Dog dog = new Dog(12);
            Owl owl = new Owl(50);

            Animal[] animals =
            {
                bird,
                dog,
                owl
            };

            Console.WriteLine("Тварини голос: ");

            foreach (var animal in animals)
            {
                animal.GetVoice();
            }

            bird.ShowMaxHeightOfFlight();
            owl.ShowMaxHeightOfFlight();

            Console.WriteLine("Максимальни швидкість: ");

            foreach (var animal in animals)
            {
                animal.ShowSpeedMovement();
            }
        }
    }
}
