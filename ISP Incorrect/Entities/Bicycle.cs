using SOLID_Practice.Interfaces;
using System;

namespace SOLID_Practice.Entities
{
    class Bicycle : ITransport, IRepair
    {
        public  void Repair() => Console.WriteLine("Bicycle repair");

        public void Move() => Console.WriteLine("Bicycle move");

        public void Park() => Console.WriteLine("Bicycle park");
        
        public void Refuel() => throw new Exception();
    }
}
