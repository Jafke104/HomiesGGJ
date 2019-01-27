using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public List<int> choices;

    // TESTING ONLY
    private void Start() {
        newGame();
        choices.Add(0);
    }

    public void newGame() {
        choices = new List<int>();
    }

    public void addChoices(int choice) {
        choices.Add(choice);
    }
}
