using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsMenuController : MonoBehaviour
{
    public AudioSource audioSource;
    private float volume = 1f;

    private void Update()
    {
        audioSource.volume = volume;
    }
    public void UpdateVolume(float newVolume)
    {
        volume = newVolume;
    } 
}
