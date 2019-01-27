using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public GameObject[] bgmMusicList;
    public GameObject[] sfxMusicList;
    public Slider bgmVolume;
    public Toggle bgmMuted;
    public Slider sfxVolume;
    public Toggle sfxMuted;

    // Start is called before the first frame update
    void Start() {
        if (!PlayerPrefs.HasKey("BGMVolume") && !PlayerPrefs.HasKey("SFXVolume")) {
            PlayerPrefs.SetFloat("BGMVolume", 1);
            PlayerPrefs.SetFloat("SFXVolume", 1);
            PlayerPrefs.SetInt("BGMMuted", 0);
            PlayerPrefs.SetInt("SFXMuted", 0);
        }

        bgmMusicList = GameObject.FindGameObjectsWithTag("BGM");
        sfxMusicList = GameObject.FindGameObjectsWithTag("SFX");
        if (bgmVolume != null) {
            bgmVolume.value = PlayerPrefs.GetFloat("BGMVolume");
            bgmMuted.isOn = PlayerPrefs.GetInt("BGMMuted") == 1;
            sfxVolume.value = PlayerPrefs.GetFloat("SFXVolume");
            sfxMuted.isOn = PlayerPrefs.GetInt("SFXMuted") == 1;
        }
    }

    // Update is called once per frame
    void Update() {
        if (bgmVolume != null) {
            if (bgmMusicList.Length > 0) { 
                foreach (GameObject music in bgmMusicList) {
                    if (bgmMuted.isOn) {
                        music.GetComponent<AudioSource>().volume = 0;
                    } else {
                        music.GetComponent<AudioSource>().volume = bgmVolume.value;
                    }
                }
            }

            if (sfxMusicList.Length > 0) { 
                foreach (GameObject music in sfxMusicList) {
                    if (sfxMuted.isOn) {
                        music.GetComponent<AudioSource>().volume = 0;
                    } else {
                        music.GetComponent<AudioSource>().volume = sfxVolume.value;
                    }
                }
            }    
        }           
    }

    public void SaveVolumeSettings() {
        if (bgmVolume != null) {
            PlayerPrefs.SetFloat("BGMVolume", bgmVolume.value);
            PlayerPrefs.SetFloat("SFXVolume", sfxVolume.value);
            if (bgmMuted != null && bgmMuted.isOn) {
                PlayerPrefs.SetInt("BGMMuted", 1);
            } else {
                PlayerPrefs.SetInt("BGMMuted", 0);
            }

            if (sfxMuted != null &&sfxMuted.isOn) {
                PlayerPrefs.SetInt("SFXMuted", 1);
            } else {
                PlayerPrefs.SetInt("SFXMuted", 0);
            }
        }
    }
}
