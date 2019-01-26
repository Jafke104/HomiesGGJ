using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseFunctions : MonoBehaviour
{
    private bool GamePaused;
    [SerializeField]
    private GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GamePaused) {
                UnpauseGame();
            } else {
                PauseGame();
            }
        }
    }

    public void PauseGame() {
        // Debug.Log("Game is paused");
        GamePaused = true;
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void UnpauseGame() {
        // Debug.Log("Game is unpaused");
        GamePaused = false;
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
}
