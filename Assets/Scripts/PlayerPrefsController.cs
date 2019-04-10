﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string SFX_VOLUME_KEY = "SFX volume";
    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        else
            Debug.LogError("Volume out of Range");
    }

    public static void SetSFXVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
            PlayerPrefs.SetFloat(SFX_VOLUME_KEY, volume);
        else
            Debug.LogError("Volume out of Range");
    }


    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static float GetSFXVolume()
    {
        return PlayerPrefs.GetFloat(SFX_VOLUME_KEY);
    }

}    

