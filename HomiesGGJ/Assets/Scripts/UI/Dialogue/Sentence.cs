using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sentence {
    public string m_name;
    public string m_sentence;

    public Sentence(string name, string sentence) {
        m_name = name;
        m_sentence = sentence;
    }
}
