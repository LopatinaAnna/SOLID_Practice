using System;

namespace SOLID_Practice.Entities
{
    public class Car : RefuelTransport
    {
        public override void Repair() => Console.WriteLine("Car repair");
    }
}