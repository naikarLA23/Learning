using StatePattern.State;

namespace StatePattern.Context
{
    internal class OrderContext(IOrderState currentState) /*: IOrderState*/
    {
        private IOrderState _currentState = currentState;

        public void SetState(IOrderState state)
        {
            _currentState = state;
        }

        public void NextState()
        {
            _currentState.SetNextState(this);
        }
        public void PrevState()
        {
            _currentState.SetPreviousState(this);
        }
        public void DisplayState()
        {
            _currentState.DisplayState();
        }
    }
}
