using SOLID_Practice.Entities;
using SRP_Correct.Entities;

namespace OCP_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullViewer = new TransportStateFullViewer();

            var car = new Car
            {
                Model = "BMW X5",
                Speed = 100,
                CurrentFuel = 250
            };

            fullViewer.ShowCurrentState(car);
        }
    }
}
