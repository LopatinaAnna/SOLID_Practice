using SOLID_Practice.Entities;
using System;

namespace SRP_Correct.Entities
{
    public class TransportStateViewer
    {
        public void ShowCurrentState(Transport transport)
            => Console.WriteLine($"Speed: {transport.Speed}, fuel: {transport.CurrentFuel}");
    }
}
