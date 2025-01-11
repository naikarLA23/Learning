using InterpreterPatter.Expression;
using InterpreterPatter.Expression.ConcreteExpression;
using System.Linq.Expressions;

namespace InterpreterPatter.Context
{
    internal class MathExpressionResolver()
    {
        public IMathOperator Parse(string expression)
        {
            var tokens = expression.Split(' ');
            IMathOperator leftExpression = new NumberExp(float.Parse(tokens[0]));

            for (int i = 1; i < tokens.Length; i += 2)
            {
                switch (tokens[i])
                {
                    case "+":
                        leftExpression = new Addition(leftExpression, new NumberExp(float.Parse(tokens[i + 1])));
                        break;
                    case "-":
                        leftExpression = new Substraction(leftExpression, new NumberExp(float.Parse(tokens[i + 1])));
                        break;
                    case "*":
                        leftExpression = new Multiplication(leftExpression, new NumberExp(float.Parse(tokens[i + 1])));
                        break;
                    case "/":
                        leftExpression = new Division(leftExpression, new NumberExp(float.Parse(tokens[i + 1])));
                        break;
                }
            }

            return leftExpression;
        }
    }
}
