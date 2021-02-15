using System;

namespace SOLID_Practice.Entities
{
    class Bicycle : Transport
    {
        public override void Repair() => Console.WriteLine("Car repair");

        public override void Refuel() => throw new Exception();
    }
}
