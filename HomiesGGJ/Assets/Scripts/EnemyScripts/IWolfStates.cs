using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWolfStates
{
    void Execute();
    void Enter(Wolf wolf);
    void Exit();
    void OnTriggerEnter(Collider2D other);

}
