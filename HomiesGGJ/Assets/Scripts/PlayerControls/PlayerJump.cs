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

    public Animator animator;

    RaycastHit2D groundInfo;
    [SerializeField]
    bool isGrounded;

    [SerializeField]
    int JumpCount = 0;
    public int MaxJumps = 1;

    Rigidbody2D rb;

    private void Start()
    {
        jumpVelocity = 7;
        JumpCount = MaxJumps;
    }

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){

        //using raycast to check if player is on ground or not
        RaycastHit2D groundInfo = Physics2D.Raycast(this.transform.position, Vector2.down, .6f);
        Debug.DrawRay(this.transform.position, Vector2.down * .6f, Color.green, .6f);
        if (!groundInfo)
        {
            Debug.Log("Not on ground");
            isGrounded = false;
            JumpCount = JumpCount - 1;
            animator.SetBool("IsJumping", true);
        }
        else
        {
            Debug.Log("On ground");
            isGrounded = true;
            JumpCount = MaxJumps;
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsFalling", false);
        }


        if (Input.GetButtonDown ("Jump"))
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
            animator.SetBool("IsFalling", true);
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            animator.SetBool("IsFalling", false);
        }
    }
}





