using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    private float currentTime;
    private bool isActive = false;
    public TextMeshProUGUI timerDisplay;
    public TextMeshProUGUI scoreDisplay;
    private void Start()
    {
        currentTime = 0f;
        StartTimer();
    }

    private void Update()
    {
        if (isActive)
        {
            currentTime += Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerDisplay.text = time.ToString(@"mm\:ss\:fff");
    }
    public void StartTimer()
    {
        isActive = true;
    }
    public void StopTimer()
    {
        isActive = false;
    }

    public void StartAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
