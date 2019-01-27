using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneStart : MonoBehaviour
{
    public GameObject DialogueController;
    public string filename;
    // Start is called before the first frame update
    void Start()
    {
        DialogueController.GetComponent<DialogueController>().StartDialogue(filename);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
