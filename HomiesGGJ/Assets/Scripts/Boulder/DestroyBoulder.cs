﻿//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoulder : MonoBehaviour
{
    GameObject boulder;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("boulder")) {
            Debug.Log("Destroying Boulder");
            Destroy(GameObject.FindWithTag("boulder"));
        }
    }
}
