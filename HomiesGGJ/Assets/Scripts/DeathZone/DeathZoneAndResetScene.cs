//By Kristopher Kath
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZoneAndResetScene : MonoBehaviour
{
    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        RestartScene();
    }

}
