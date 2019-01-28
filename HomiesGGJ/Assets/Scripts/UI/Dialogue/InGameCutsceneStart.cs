using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCutsceneStart : MonoBehaviour
{
    public GameObject DialogueController;
    public bool started;
    public string stringNames;

    private void Start() {
        started = false;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player" && started ==  false)
        {
            DialogueController.GetComponent<DialogueController>().StartDialogue(stringNames);
            started = true;
        }
    }
}
