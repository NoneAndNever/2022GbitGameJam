using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoungManager : MonoBehaviour
{
    public static SoungManager Instance;

    enum _soundType
    {
        BGM1,
        BGM2,
        BGM3,
        BGM4
    }

    [SerializeField] private AudioSource BGM;

    [SerializeField] private AudioClip BGM1, BGM2, BGM3, BGM4;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else Destroy(Instance);
    }

    public void PlaySound(Enum soundType)
    {
        switch (soundType)
        {
            case _soundType.BGM1:
                BGM.clip = BGM1;
                break;
            case _soundType.BGM2:
                BGM.clip = BGM2;
                break;
            case _soundType.BGM3:
                BGM.clip = BGM3;
                break;
            case _soundType.BGM4:
                BGM.clip = BGM4;
                break;
            default:
                break;
        }

        BGM.loop = true;
        BGM.Play();
    }

    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;
    }
}
