using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class PlayerPrefsHandler : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    Slider volumeSlider;
    [SerializeField]
    Toggle muteToggle;
    [SerializeField]
    Toggle fullscreenToggle;
    [SerializeField]
    AudioSource musicSource;
    private void Awake()
    {
        #region AudioPrefs
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);
        audioSource.volume = PlayerPrefs.GetFloat("volume", 1f);
        musicSource.volume = PlayerPrefs.GetFloat("volume", 1f);
        
        if (PlayerPrefs.GetInt("mute", 1) == 0)
        {
            muteToggle.isOn = false;
            audioSource.mute = true;
        }
        else
        {
            muteToggle.isOn = true;
            audioSource.mute = false;
        }
        #endregion

        #region ScreenPrefs
        if (PlayerPrefs.GetInt("fullscreen", 1) == 0)
        {
            fullscreenToggle.isOn = false;
            Screen.fullScreen = false;
        }
        else
        {
            fullscreenToggle.isOn = true;
            Screen.fullScreen = true;
        }
        #endregion
    }
}
