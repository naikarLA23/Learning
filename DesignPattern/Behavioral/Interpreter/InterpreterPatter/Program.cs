using InterpreterPatter.Context;
using System.Linq.Expressions;

namespace InterpreterPatter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var parser = new MathExpressionResolver();

            while (true)
            {
                try
                {
                    Console.WriteLine($"Please enter your expression with SPACES.( Example : 3 + 5 - 2 )");
                    //var expression = parser.Parse("3 + 5 - 2");
                    var inputStr = Console.ReadLine().Trim();
                    var expression = parser.Parse(inputStr);

                    Console.WriteLine($"Result: {expression.Evaluate()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Result: {ex.Message}");
                }
                Console.WriteLine($"\n-------------------------------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
