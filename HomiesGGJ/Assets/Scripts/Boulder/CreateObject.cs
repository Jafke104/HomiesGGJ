//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    void OnTriggerEnter2D()
    {
        if (this.enabled)
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            this.enabled = false;
        }

    }
}
