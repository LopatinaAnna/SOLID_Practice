using SOLID_Practice.Entities;
using SRP_Correct.Entities;

namespace DIP_Incorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            var viewer = new TransportViewer();

            var car = new Car { Model = "BMW X5", Speed = 100 };

            viewer.ShowCurrentState(car);
        }
    }
}
