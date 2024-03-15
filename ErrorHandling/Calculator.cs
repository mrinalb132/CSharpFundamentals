using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public static class Calculator
    {
        public static int Calculate(int n1, int n2, string operation)
        {
            switch(operation)
            {
                case "+": return n1 + n2;
                case "-": return n1 - n2;
                case "*": return n1 * n2;
                case "/": return n1 / n2;
                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(operation), "The operation is not supported");
                    }
            }
        }
    }
}
