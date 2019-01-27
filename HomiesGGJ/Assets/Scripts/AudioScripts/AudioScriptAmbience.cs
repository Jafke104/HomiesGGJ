using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScriptAmbience : MonoBehaviour
{

    public AudioClip MusicClip;

    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.clip = MusicClip;
        MusicSource.volume = 0.3f;
        MusicSource.Play();
    }
}
