using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalFunctions : MonoBehaviour {
    public GameObject AudioManager;

    public void NewGame() {
        GameManager.current.newGame();
    }

    public void ChangeScene(string SceneName) {
        AudioManager.GetComponent<AudioManager>().SaveVolumeSettings();
        SceneManager.LoadScene(SceneName);     
    }

    public void QuitGame() {
        AudioManager.GetComponent<AudioManager>().SaveVolumeSettings();
        Application.Quit();
    }
}
