using System;

namespace SOLID_Practice.Entities
{
    public class Plane : Transport
    {
        public void BaggageDrop() => Console.WriteLine("Baggage drop");

        public override void Repair() => Console.WriteLine("Plane repair");
    }
}