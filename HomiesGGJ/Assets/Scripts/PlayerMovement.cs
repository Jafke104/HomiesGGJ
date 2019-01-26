using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float Dirx = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + Dirx, transform.position.y);

    }
}
