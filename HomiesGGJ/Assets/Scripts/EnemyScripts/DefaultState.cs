using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultState : IWolfStates
{
    private Wolf wolf;
    public void Execute()
    {
        Debug.Log("Default state");
        if(wolf.target != null)
        {
            wolf.changeState(new ChaseState());
        }
        wolf.move();
    }

    public void Enter(Wolf wolf)
    {
        this.wolf = wolf;
    }

    public void Exit()
    {
        
    }

    public void OnTriggerEnter(Collider2D other)
    {

    }
}
