using Interview.Core.Common.Helpers;
using Interview.Core.Domain.Interfaces;

namespace Interview.Core.Domain.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IPrinterService _printerService;

        public FizzBuzzService(IPrinterService printerService)
        {
            _printerService = printerService;
        }

        public string Output(int number)
        {
            string line = null;

            if (number.IsDivisibleBy(3))
                line = "Fizz";

            if (number.IsDivisibleBy(5))
                line += "Buzz";

            return line ?? number.ToString();
        }

        public void InputRange(int start, int end)
        {
            for (var n = start; n <= end; n++)
                _printerService.Print(Output(n));
        }
    }
}
