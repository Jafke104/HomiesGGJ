using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{

    [SerializeField] protected float speed = 1.625f;
    public GameObject target { get; set; }

    public Collider2D m_collider;
    public bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        m_collider = this.GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rightCorner = new Vector3(this.transform.position.x + .5f, m_collider.bounds.min.y);
        Vector3 leftCorner = new Vector3(this.transform.position.x - .5f, m_collider.bounds.min.y);

        RaycastHit2D rightGroundInfo = Physics2D.Raycast(rightCorner, Vector2.down, .6f);
        RaycastHit2D leftGroundInfo = Physics2D.Raycast(leftCorner, Vector2.down, .6f);

        Debug.DrawRay(rightCorner, Vector2.down * .6f, Color.green, .6f);
        Debug.DrawRay(leftCorner, Vector2.down * .6f, Color.green, .6f);

        

        if (!rightGroundInfo)
        {
            facingRight = false;
            flip();
        }
        if (!leftGroundInfo)
        {
            facingRight = true;
            flip();
        }

        if (facingRight)
        {
            moveRight();
            
        }
        else
        {
            moveLeft();
        }
    }

    void flip()
    {
        Vector3 newScale = this.transform.localScale;
        newScale.x *= -1;
        this.transform.localScale = newScale;
    }

    void moveRight()
    {
        this.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void moveLeft()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
