using Interview.Core.Domain.Interfaces;
using Interview.Core.Domain.Services;

namespace Interview.Core.Common.DI
{
    public class DI
    {
        public static IPrinterService CreatePrinterService()
        {
            return new PrinterService();
        }

    }
}
