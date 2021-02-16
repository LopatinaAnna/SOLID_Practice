using SOLID_Practice.Entities;
using SOLID_Practice.Interfaces;

namespace ISP_Correct
{
    class Program
    {
        private static void Main(string[] args)
        {
            var transports = new IRefuel[]
            {
                new Car(),
                new Plane()
            };

            RefuelAllTransport(transports);

            var transports2 = new ITransport[]
            {
                new Car(),
                new Plane(),
                new Bicycle()
            };

            MoveAllTransport(transports2);
        }

        private static void RefuelAllTransport(IRefuel[] transports)
        {
            foreach (var transport in transports)
            {
                transport.Refuel();
            }
        }

        private static void MoveAllTransport(ITransport[] transports)
        {
            foreach (var transport in transports)
            {
                transport.Move();
            }
        }
    }
}
