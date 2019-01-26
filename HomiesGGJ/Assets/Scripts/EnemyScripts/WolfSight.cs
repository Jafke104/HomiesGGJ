using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfSight : MonoBehaviour
{
    [SerializeField] private Wolf wolf;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            wolf.target = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            wolf.target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
