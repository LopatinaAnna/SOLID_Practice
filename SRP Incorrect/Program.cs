using SOLID_Practice.Entities;

namespace SRP_Incorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                Model = "BMW X5",
                Speed = 100,
                CurrentFuel = 250
            };

            car.ShowCurrentState();
        }
    }
}
