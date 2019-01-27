using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Dialogue {
    public Queue<Sentence> initialDialogue;
    public Question question;
    public Queue<Sentence> response1;
    public Queue<Sentence> response2;

    private FileInfo sourceFile;

    private StreamReader reader;

    private string text;

    private string speaker;
    private string sentence;
    private string answer1;
    private string answer2;


    public void ConstructDialogue(string filename) {
        initialDialogue = new Queue<Sentence>();
        response1 = new Queue<Sentence>();
        response2 = new Queue<Sentence>();

        sourceFile = new FileInfo("Assets/Resources/CutsceneText/" + filename);
        reader = sourceFile.OpenText();

        while (!reader.EndOfStream) {
            text = reader.ReadLine();
            if (text.IndexOf("@Q") != -1) {
                speaker = text.Substring(2, text.IndexOf(':') - 2);
                sentence = text.Substring(text.IndexOf(':') + 1);
                answer1 = reader.ReadLine();
                answer2 = reader.ReadLine();
                question = new Question(speaker, sentence, answer1, answer2);
            } else if (text.IndexOf("@1") != -1) {
                speaker = text.Substring(2, text.IndexOf(':') - 2);
                sentence = text.Substring(text.IndexOf(':') + 1);
                response1.Enqueue(new Sentence(speaker, sentence));
            } else if (text.IndexOf("@2") != -1) {
                speaker = text.Substring(2, text.IndexOf(':') - 2);
                sentence = text.Substring(text.IndexOf(':') + 1);
                response2.Enqueue(new Sentence(speaker, sentence));
            } else {
                speaker = text.Substring(0, text.IndexOf(':'));
                sentence = text.Substring(text.IndexOf(':') + 1);
                initialDialogue.Enqueue(new Sentence(speaker, sentence));
            }
        }
    }
}
