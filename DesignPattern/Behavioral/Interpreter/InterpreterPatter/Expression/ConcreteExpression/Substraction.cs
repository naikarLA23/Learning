﻿namespace InterpreterPatter.Expression.ConcreteExpression
{
    internal class Substraction(IMathOperator leftMathOperator, IMathOperator rightMathOperator) : IMathOperator
    {
        private IMathOperator _leftMathOperator = leftMathOperator;
        private IMathOperator _righttMathOperator = rightMathOperator;

        public float Evaluate()
        {
            return leftMathOperator.Evaluate() - rightMathOperator.Evaluate();
        }
    }
}