using SOLID_Practice.Entities;

namespace DIP_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            var viewer = new TransportViewer(new PrintToConsole());

            var car = new Car { Model = "BMW X5", Speed = 100 };

            viewer.ShowCurrentState(car);
        }
    }
}
