using SOLID_Practice.Interfaces;
using System;

namespace SOLID_Practice.Entities
{
    public abstract class Transport : ITransport, IRepair
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public int CurrentFuel { get; set; }

        public virtual void Move() => Console.WriteLine("Base move");

        public virtual void Park() => Console.WriteLine("Base park");

        public virtual void Refuel() => Console.WriteLine("Base refuel");

        public abstract void Repair();

        public override string ToString() => string.Join(' ', GetType().Name, Model);
    }
}
