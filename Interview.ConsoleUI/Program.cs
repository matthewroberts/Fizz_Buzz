using System;
using Interview.Core.Common.DI;
using Interview.Core.Domain.Interfaces;
using Interview.Core.Domain.Services;

namespace Interview.ConsoleUI
{
    public class Program
    {
        private static IFizzBuzzService _fizzBuzzService;

        static void Main(string[] args)
        {
            _fizzBuzzService = new FizzBuzzService(DI.CreatePrinterService());

            _fizzBuzzService.InputRange(1,100);
            Console.ReadLine();
        }
    }
}
