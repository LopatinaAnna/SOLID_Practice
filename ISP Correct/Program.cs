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
        }

        private static void RefuelAllTransport(IRefuel[] transports)
        {
            foreach (var transport in transports)
            {
                transport.Refuel();
            }
        }
    }
}
