public class StateMachine
{
    public State _currentState { get; set; }

    public void Initialize(State _startState)
    {
        _currentState = _startState;
        _startState.Enter();
    }

    public void ChangeState(State _newState)
    {
        _currentState.Exit();
        _currentState = _newState;
        _newState.Enter();
    }
}