using SOLID_Practice.Interfaces;
using System;

namespace SOLID_Practice.Entities
{
    internal class Bicycle : IMove, IPark, IRepair
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public void Move() => Console.WriteLine("Bicycle move");

        public void Park() => Console.WriteLine("Bicycle park");

        public void Repair() => Console.WriteLine("Bicycle repair");
    }
}