//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    int JumpCount = 0;
    public int MaxJumps = 1;

    Rigidbody2D rb;

    private void Start()
    {
        JumpCount = MaxJumps;
    }

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){

        if(Input.GetButtonDown ("Jump"))
        {
            if (JumpCount > 0)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
                JumpCount -= 1;
            }
        }


        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "ground")
        {
            JumpCount = MaxJumps;
        }
    }
}





