using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class ChangeToFall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.GameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Fall Season");
        }
    }

}
