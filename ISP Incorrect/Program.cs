using SOLID_Practice.Entities;
using SOLID_Practice.Interfaces;

namespace ISP_Incorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            var transports = new ITransport[]
            {
                new Car(),
                new Plane(),
                new Bicycle()
            };

            RefuelAllTransport(transports);
        }

        static void RefuelAllTransport(ITransport[] transports)
        {
            foreach (var transport in transports)
            {
                transport.Refuel(); // Exception on Bicycle.Refuel()
            }
        }
    }
}
