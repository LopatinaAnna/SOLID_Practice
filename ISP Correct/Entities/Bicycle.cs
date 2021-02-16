using System;

namespace SOLID_Practice.Entities
{
    public class Bicycle : Transport
    {
        public override void Repair() => Console.WriteLine("Bicycle repair");
    }
}