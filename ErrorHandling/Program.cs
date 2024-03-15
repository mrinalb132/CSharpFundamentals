using System;
using static System.Console;
namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Enter the first no:");
                int num1 = int.Parse(ReadLine()!);
                WriteLine("Enter the second no:");
                int num2 = int.Parse(ReadLine()!);
                WriteLine("Enter the operation:");
                string ops = ReadLine()!.ToUpperInvariant();
                var result = Calculator.Calculate(num1, num2, ops);
                WriteLine($"The result is : {result}");
            }
            catch(FormatException ex)
            {
                WriteLine($"Format error occurred during readline: {ex.Message}");
            }
            catch(DivideByZeroException ex)
            {
                // throw ex; //it changes the call stack, itstead just throw  the exception
                //throw;

                WriteLine("Divide by zero occurred");

            }
            catch(ArgumentOutOfRangeException ex) when(ex.ParamName == "operation")
            {
                WriteLine("Operation entered as null");
            }
            catch(ArgumentOutOfRangeException ex) when(ex.ParamName == "n1")
            {
                WriteLine("Input values were entered null");
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
