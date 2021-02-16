using System;

namespace SOLID_Practice.Entities
{
    public class Plane : RefuelTransport
    {
        public void BaggageDrop() => Console.WriteLine("Baggage drop");

        public override void Repair() => Console.WriteLine("Plane repair");
    }
}