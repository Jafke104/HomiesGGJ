//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Animator animator;

    public float Speed = 10f;
    
    private GameMaster gm;

    private void Start()
    {
        //gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<GameMaster>();
    }

    void FixedUpdate()
    {
        
        float Dirx = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + Dirx, transform.position.y);

        animator.SetFloat("Speed", Mathf.Abs(Dirx));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pickup"))
        {
            Destroy(collision.gameObject);
            gm.points += 1;
        }
    }
}
