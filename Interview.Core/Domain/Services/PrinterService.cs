using System;
using Interview.Core.Domain.Interfaces;

namespace Interview.Core.Domain.Services
{
    public class PrinterService : IPrinterService
    {
        public void Print(string line)
        {
            Console.WriteLine(line);
        }
    }
}
