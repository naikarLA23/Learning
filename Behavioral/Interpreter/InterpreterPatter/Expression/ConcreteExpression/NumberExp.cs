namespace InterpreterPatter.Expression.ConcreteExpression
{
    internal class NumberExp(float number) : IMathOperator
    {
        private float _number = number;

        public float Evaluate()
        {
            return _number;
        }
    }
}