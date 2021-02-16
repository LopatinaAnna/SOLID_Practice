using SOLID_Practice.Entities;
using System;

namespace SRP_Correct.Entities
{
    public class Printer
    {
        public void Print(string content) => Console.WriteLine(content);
    }

    public class TransportViewer
    {
        Printer printer = new Printer();

        public virtual void ShowCurrentState(Transport transport)
        {
            string content = $"Model: {transport.Model} \nSpeed: {transport.Speed}";
            printer.Print(content);
        }
    }
}