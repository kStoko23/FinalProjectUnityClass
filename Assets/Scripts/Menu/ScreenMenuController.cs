using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenMenuController : MonoBehaviour
{
    Resolution[] resolutions;
    private List<Resolution> filteredResolutions;
    private int currentResolutionIndex;
    private float currentRefreshRate;
    [SerializeField] 
    TMP_Dropdown resolutionDropdown;
    private void Start()
    {
        resolutionDropdown.ClearOptions();
        resolutions = Screen.resolutions;
        filteredResolutions = new List<Resolution>();
        currentRefreshRate = Screen.currentResolution.refreshRate;
        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredResolutions.Add(resolutions[i]);
            }
        }
        
        List<string> options = new List<string>();
        for (int i = 0; i < filteredResolutions.Count; i++)
        {
            string option = filteredResolutions[i].width + " x " + filteredResolutions[i].height + " " + filteredResolutions[i].refreshRate + "Hz";
            options.Add(option);
            if (filteredResolutions[i].width == Screen.currentResolution.width && filteredResolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        PlayerPrefs.SetInt("fullscreen", Convert.ToInt32(isFullScreen));
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = filteredResolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen, resolution.refreshRate);
    }
}
