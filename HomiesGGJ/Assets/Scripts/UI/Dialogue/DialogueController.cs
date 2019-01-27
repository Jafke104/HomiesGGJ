using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour {
    public int scene;
    [SerializeField]
    private string filename;

    private int cutscenePosition;
    [SerializeField]
    private GameObject GlobalFuncts;
    [SerializeField]
    private GameObject DialogueBox;
    [SerializeField]
    private float delay;
    private Queue<Sentence> currentDialogue;
    private Sentence sentence;

    [SerializeField]
    private GameObject continueButton;
    [SerializeField]
    private GameObject answer1Button;
    [SerializeField]
    private GameObject answer2Button;

    private Dialogue sceneDialogue;

    private int choice;

    [SerializeField]
    private TMPro.TextMeshProUGUI cutsceneText;
    [SerializeField]
    private TMPro.TextMeshProUGUI nameText;

    private void Awake() {
        sceneDialogue = new Dialogue();
        cutscenePosition = 0;
        
    }

    public void StartDialogue (string fileName) {
        print(fileName);
        filename = fileName;
        DialogueBox.SetActive(true);

        sceneDialogue.ConstructDialogue(fileName);
        currentDialogue = sceneDialogue.initialDialogue;

        DisplayNextSentences("");
        
    }

    public void DisplayNextSentences(string nextScene) {
        if ((cutscenePosition == 0 && sceneDialogue.question == null && sceneDialogue.initialDialogue.Count == 0) ||
            (cutscenePosition == 1 && (sceneDialogue.response1 == null ||sceneDialogue.response1.Count == 0 
            || sceneDialogue.response2.Count == 0))) {
            EndDialogue(nextScene);
        } else {
            if (cutscenePosition == 0 && sceneDialogue.initialDialogue.Count == 0 && sceneDialogue.question != null) {
                cutscenePosition++;
                continueButton.SetActive(false);
                answer1Button.SetActive(true);
                answer2Button.SetActive(true);
                nameText.text = sceneDialogue.question.m_name;
                StopAllCoroutines();
                StartCoroutine(TypeSentence(sceneDialogue.question.m_sentence));
                answer1Button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = sceneDialogue.question.m_answer1;
                answer2Button.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = sceneDialogue.question.m_answer2;
            } else {
                answer1Button.SetActive(false);
                answer2Button.SetActive(false);
                continueButton.SetActive(true);
                StopAllCoroutines();
                sentence = currentDialogue.Dequeue();

                if (filename == "Stage3.5.txt" || filename == "Stage.3.6.txt")
                {
                    if (GameManager.current.choices[0] == 0)
                    {
                        if (sentence.m_sentence.IndexOf("Carly/Pierre") != -1)
                        {
                            sentence.m_sentence = sentence.m_sentence.Replace("Carly/Pierre", "Carly");
                        }
                        else if (sentence.m_sentence.IndexOf("Wife/Husband") != -1)
                        {
                            sentence.m_sentence = sentence.m_sentence.Replace("Wife/Husband", "Wife");
                        }
                    }
                    else
                    {
                        if (sentence.m_sentence.IndexOf("Carly/Pierre") != -1)
                        {
                            sentence.m_sentence = sentence.m_sentence.Replace("Carly/Pierre", "Pierre");
                        }
                        else if (sentence.m_sentence.IndexOf("Wife/Husband") != -1)
                        {
                            sentence.m_sentence = sentence.m_sentence.Replace("Wife/Husband", "Husband");
                        }
                    }
                }
                
                nameText.text = sentence.m_name;
                StartCoroutine(TypeSentence(sentence.m_sentence));
            }   
        }            
    }

    IEnumerator TypeSentence(string sentence) {
        cutsceneText.text = "";
        foreach (char letter in sentence.ToCharArray()) {
            cutsceneText.text += letter;
            yield return new WaitForSeconds(delay);
        }
    }

    public void AnswerQuestion(int answer) {      
        if (answer == 0) {
            currentDialogue = sceneDialogue.response1;
        } else {
            currentDialogue = sceneDialogue.response2;
        }
        GameManager.current.addChoices(answer);

        if (scene == 1) {
            GlobalFuncts.GetComponent<GlobalFunctions>().ChangeScene("Cutscene_Tent");
        }

        DisplayNextSentences("");
    }

    public void EndDialogue(string nextScene) {
        if (nextScene != "") {
            GlobalFuncts.GetComponent<GlobalFunctions>().ChangeScene(nextScene);
        }
        DialogueBox.SetActive(false);
    }
}
