using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IWolfStates
{
    private Wolf wolf;
    public void Execute()
    {
        Debug.Log("Chase state");
        wolf.move();
        if( wolf.target == null )
        {
            Exit();
            wolf.changeState(new DefaultState());
        }
    }

    public void Enter(Wolf wolf)
    {
        this.wolf = wolf;
        wolf.setSpeed(2.5f);
    }

    public void Exit()
    {
        wolf.setSpeed(1f);
    }

    public void OnTriggerEnter(Collider2D other)
    {

    }
}
