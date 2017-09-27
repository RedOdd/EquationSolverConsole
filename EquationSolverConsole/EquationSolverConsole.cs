using System;
using EquationSolverNamespace;

namespace EquationSolverConsole
{
    class EquationSolverConsole
    {
        static void Main(string[] args)
        {
            var equation = Console.ReadLine();
            var coefficients = EquationSolver.ParseEquation(equation);
            var discriminat = EquationSolver.FindDiscriminant(coefficients);
            if (EquationSolver.IsValidationOfDiscriminantIsTrue(discriminat))
            {
                var firstValue = EquationSolver.FindFirstValue(coefficients, discriminat);
                var secondValue = EquationSolver.FindSecondValue(coefficients, discriminat);
                var arrayOfValues = EquationSolver.ViewTwoValues(firstValue, secondValue);
                Console.WriteLine("Value: " + arrayOfValues[0]);
                if (!(arrayOfValues[0] == arrayOfValues[1]))
                {
                    Console.Write("Value: " + arrayOfValues[1]);
                }
                Console.ReadKey();
                
            } else
            {
                Console.Write("Error");
                Console.ReadKey();
            }
        }
    }
}
