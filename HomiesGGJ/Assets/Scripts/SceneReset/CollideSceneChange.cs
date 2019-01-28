using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideSceneChange : MonoBehaviour
{
    public string sceneName;

     void OnTriggerEnter2D(Collider2D col) {
    
        Debug.Log("Changing Scene");
        SceneManager.LoadScene(sceneName);
        
    }
}
    