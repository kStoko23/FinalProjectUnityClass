using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsMenuController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    private float volume = 1f;

    private void Update()
    {
        audioSource.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
    }
    public void UpdateVolume(float newVolume)
    {
        volume = newVolume;
    } 
    public void ToggleMute()
    {
        if (audioSource.mute)
        {
            audioSource.mute = false;
            PlayerPrefs.SetInt("mute", 1);
        }
        else
        {
            audioSource.mute = true;
            PlayerPrefs.SetInt("mute", 0);
        }
    }
}
