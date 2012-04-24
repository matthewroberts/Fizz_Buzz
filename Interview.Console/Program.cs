using System;
using Interview.Core.Interfaces;
using Interview.Core.Services;

namespace Interview.ConsoleUI
{
    public class Program
    {
        private static IFizzBuzzService _fizzBuzzService;

        static void Main(string[] args)
        {
            _fizzBuzzService = new FizzBuzzService();
             
            for (var n = 1; n <= 100; n++)
                Console.WriteLine(_fizzBuzzService.Output(n));
            Console.ReadLine();

        }
    }
}
