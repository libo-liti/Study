using System;
using UnityEngine;

public interface IState
{
    void Enter();
    void Update();
    void Exit();
}

public class IdleState : IState
{
    public void Enter() {}
    public void Update() {}
    public void Exit() {}
}

public class StatePlayer : MonoBehaviour
{
    private IState currentState;

    public void ChangeState(IState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    private void Update()
    {
        currentState?.Update();
    }
}
