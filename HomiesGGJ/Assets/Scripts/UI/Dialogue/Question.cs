using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question : Sentence {
    public string m_answer1;
    public string m_answer2;

    public Question(string name, string sentence, string answer1, string answer2) : base(name, sentence) {
        m_name = name;
        m_sentence = sentence;
        m_answer1 = answer1;
        m_answer2 = answer2;
    }
}
