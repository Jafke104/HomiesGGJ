using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScriptMusic : MonoBehaviour
{

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.volume = 1.5f;
        MusicSource.Play();
    }
}
