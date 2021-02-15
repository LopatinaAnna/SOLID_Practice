using System;

namespace SOLID_Practice.Entities
{
    public class Ship : Transport
    {
        public override void Repair() => Console.WriteLine("Ship repair");
    }
}