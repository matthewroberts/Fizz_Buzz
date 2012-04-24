using System.Collections.Generic;
using Interview.Core.Domain.Interfaces;

namespace Interview.Test
{
    public class PrinterServiceTest : IPrinterService
    {
        public IList<string> Lines { get; set; }

        public PrinterServiceTest()
        {
            Lines = new List<string>();
        }

        public void Print(string line)
        {
            Lines.Add(line);
        }
    }
}
