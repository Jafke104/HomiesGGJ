using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameManager {
    public static GameManager current;
    public List<int> choices;

    public GameManager() {
        choices = new List<int>();
    }

    public void addChoices(int choice) {
        choices.Add(choice);
    }

    public List<int> GetChoices() {
        return choices;
    }
}
