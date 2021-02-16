using SOLID_Practice.Interfaces;
using System;

namespace SOLID_Practice.Entities
{
    public abstract class Transport : ITransport
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public virtual void Move() => Console.WriteLine("Base move");

        public virtual void Park() => Console.WriteLine("Base park");

        public abstract void Repair();

        public override string ToString() => string.Join(' ', GetType().Name, Model);
    }
}