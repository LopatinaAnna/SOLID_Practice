using SOLID_Practice.Entities;
using System;

namespace SRP_Correct.Entities
{
    public class TransportStateShortViewer
    {
        public virtual void ShowCurrentState(Transport transport)
            => Console.WriteLine($"Model: {transport.Model} \nSpeed: {transport.Speed}");
    }

    public class TransportStateFullViewer : TransportStateShortViewer
    {
        public override void ShowCurrentState(Transport transport)
        {
            base.ShowCurrentState(transport);
            Console.WriteLine($"Fuel: {transport.CurrentFuel}");
        }
    }
}