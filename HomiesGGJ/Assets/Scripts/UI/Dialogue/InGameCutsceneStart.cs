using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCutsceneStart : MonoBehaviour
{
    private bool started;
    public GameObject DialogueController;
    public string filename;
    // Start is called before the first frame update
    void Start() {
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player" && !started) {
            started = true;
            DialogueController.GetComponent<DialogueController>().StartDialogue(filename);
        }
    }
}
