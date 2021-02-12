using SOLID_Practice.Entities;
using SRP_Correct.Entities;

namespace SRP_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateViewer = new TransportStateViewer();

            var car = new Car
            {
                Model = "BMW X5",
                Speed = 100,
                CurrentFuel = 250
            };

            stateViewer.ShowCurrentState(car);
        }
    }
}
