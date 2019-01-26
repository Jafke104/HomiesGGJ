﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalFunctions : MonoBehaviour {
    public void ChangeScene(string SceneName) {
        SceneManager.LoadScene(SceneName);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
