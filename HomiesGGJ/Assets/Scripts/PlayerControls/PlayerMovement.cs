//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    public float Speed = 10f;
 
    void FixedUpdate()
    {
        
        float Dirx = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + Dirx, transform.position.y);

        animator.SetFloat("Speed", Mathf.Abs(Dirx));

    }
}
