//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    public float Speed = 10f;

    // Right = true || Left = false
    private bool direction;
    
    // private GameMaster gm;

    private void Start()
    {
        //gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<GameMaster>();
        direction = true;
    }

    void FixedUpdate()
    {
        
        float Dirx = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + Dirx, transform.position.y);

        if ((Dirx > 0 && !direction) || (Dirx < 0 && direction)) {
            direction = !direction;
            changeDirection();
        }

        animator.SetFloat("Speed", Mathf.Abs(Dirx));

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("pickup"))
        {
            Destroy(collision.gameObject);
           // gm.points += 1;
        }
    }

    private void changeDirection() {
        if (!direction) {
            this.transform.rotation = new Quaternion(0, 180, 0, 0);
        } else {
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
