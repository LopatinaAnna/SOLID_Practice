using System;
using System.IO;
using System.Text;

namespace SOLID_Practice.Entities
{
    public interface IPrint
    {
        void Print(string content);
    }

    public class PrintToConsole : IPrint
    {
        public void Print(string content) => Console.WriteLine(content);
    }

    public class PrintToFile : IPrint
    {
        public void Print(string content)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\info.txt", false, Encoding.Default))
            {
                sw.WriteLine(content);
            }
        }
    }

    public class TransportViewer
    {
        private IPrint _printer;

        public TransportViewer(IPrint printer)
        {
            _printer = printer;
        }

        public virtual void ShowCurrentState(Transport transport)
        {
            string content = $"Model: {transport.Model} \nSpeed: {transport.Speed}";
            _printer.Print(content);
        }
    }
}