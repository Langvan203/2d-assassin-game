using UnityEngine;

public class StateMachine
{
    public EntityState currentState { get; private set; }
    
    public void Initialize(EntityState startState)
    {
        currentState = startState;
        currentState.Enter();
        
    }

    public void ChangeState(EntityState newState)
    {
        Debug.Log($"Change State: {currentState?.GetType().Name} -> {newState.GetType().Name}");
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void UpdateActiveState()
    {
        currentState.Update();
    }
}
