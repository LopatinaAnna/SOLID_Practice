using SOLID_Practice.Entities;

namespace LSP_Incorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            var transports = new Transport[] 
            { 
                new Car(),
                new Plane(),
                new Bicycle()
            };

            RefuelAllTransport(transports);
        }

        static void RefuelAllTransport(Transport[] transports)
        {
            foreach (var transport in transports)
            {
                transport.Refuel(); // Exception on Bicycle.Refuel()
            }
        }
    }
}
