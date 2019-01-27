using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private List<int> choices;

    public void newGame() {
        choices = new List<int>();
    }

    public void addChoices(int choice) {
        choices.Add(choice);
    }
}
