using ISP_Correct.Entities;
using System;

namespace SOLID_Practice.Entities
{
    public class Ship : RefuelTransport
    {
        public override void Repair() => Console.WriteLine("Ship repair");
    }
}