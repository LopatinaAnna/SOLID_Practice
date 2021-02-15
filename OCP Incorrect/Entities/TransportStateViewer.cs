using SOLID_Practice.Entities;
using System;

namespace SRP_Correct.Entities
{
    public class TransportStateViewer
    {
        public void ShowCurrentState(Transport transport, string stateType)
        {
            if (stateType == "short")
            {
                Console.WriteLine($"Speed: {transport.Speed}");
            }
            else if (stateType == "full")
            {
                Console.WriteLine($"Model: {transport.Model} \nSpeed: {transport.Speed} \nFuel: {transport.CurrentFuel}");
            }
        }
    }
}
