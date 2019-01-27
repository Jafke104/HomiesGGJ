//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticWalk : MonoBehaviour
{
    //public Animator animator;
    public float delay = .2f;
    public float Speed = 10f;

    //private GameMaster gm;

    private void Start()
    {
        StartCoroutine(initDelay());
        //gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<GameMaster>();
    }

    void FixedUpdate()
    {
 
        float Dirx = Speed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + Dirx, transform.position.y);

        //animator.SetFloat("Speed", Mathf.Abs(Dirx));

    }

    IEnumerator initDelay() {
        yield return new WaitForSeconds(delay);
    }
}