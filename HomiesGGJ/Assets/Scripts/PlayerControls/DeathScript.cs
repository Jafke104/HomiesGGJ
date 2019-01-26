using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(thisScene.name);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if ( other.collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            RestartScene();

        }
    }
}
