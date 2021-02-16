using SOLID_Practice.Entities;
using System;

namespace SRP_Correct.Entities
{
    public interface IView
    {
        void ShowCurrentState(Transport transport);
    }

    public class TransportStateShortViewer : IView
    {
        public void ShowCurrentState(Transport transport)
            => Console.WriteLine($"Model: {transport.Model} \nSpeed: {transport.Speed}");
    }

    public class TransportStateFullViewer : IView
    {
        public void ShowCurrentState(Transport transport)
        {
            Console.WriteLine($"Model: {transport.Model}");
            Console.WriteLine($"Speed: {transport.Speed}");
            Console.WriteLine($"Fuel: {transport.CurrentFuel}");
        }
    }
}
