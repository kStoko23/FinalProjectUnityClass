using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsGameHandler : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource GameOverSource;
    [SerializeField] AudioSource GameWonSource;

    private void Awake()
    {
        #region AudioPrefs
        musicSource.volume = PlayerPrefs.GetFloat("volume", 1f);
        GameOverSource.volume = PlayerPrefs.GetFloat("volume", 1f);
        GameWonSource.volume = PlayerPrefs.GetFloat("volume", 1f);
        #endregion
    }
}
