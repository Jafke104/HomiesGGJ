using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class ChangeToWinter : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.GameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("WinterSeason");
        }
    }
}
