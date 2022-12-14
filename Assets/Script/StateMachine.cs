using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public interface IState
    {
        void Enter();
        void Execute();
        void Exit();
    }



public class StateMachine : MonoBehaviour
{
    // Start is called before the first frame updatepublic interface IState
    IState currentState;
    public void ChangeState(IState newState)
    {
        if (currentState != null)
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
    public void Update()
    {
        if (currentState != null) currentState.Execute();
    }
}
