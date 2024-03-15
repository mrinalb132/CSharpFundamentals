using System;
using static System.Console;
namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the first no:");
            int num1 = int.Parse(ReadLine()!);
            WriteLine("Enter the second no:");
            int num2 = int.Parse(ReadLine()!);
            WriteLine("Enter the operation:"); 
            string ops = ReadLine()!.ToUpperInvariant();
            try
            {
                var result = Calculator.Calculate(num1, num2, ops);
                Write($"The result is : {result}");
            }
            catch (Exception ex)
            {
                WriteLine($"Exception has raised: {ex}");
            }

            finally
            {
                WriteLine("Execution completed");
            }
           

            
            
        }
    }
}
