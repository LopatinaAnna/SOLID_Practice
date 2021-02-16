using SOLID_Practice.Entities;
using SOLID_Practice.Interfaces;
using System;

namespace ISP_Correct.Entities
{
    public abstract class RefuelTransport : Transport, IRefuel
    {
        public int CurrentFuel { get; set; }

        public virtual void Refuel() => Console.WriteLine("RefuelTransport refuel");
    }
}
