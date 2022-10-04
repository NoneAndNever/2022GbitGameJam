using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoungManager : MonoBehaviour
{
    public static SoungManager Instance;

    public enum _soundType
    {
        BGM1,
        BGM2,
        BGM3,
        BGM4
    }

    [SerializeField] private AudioSource BGM;
    private _soundType tampBGM;

    [SerializeField] private AudioClip BGM1, BGM2, BGM3, BGM4;
    private AudioClip nowBGM;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else Destroy(Instance);

        tampBGM = _soundType.BGM1;
        nowBGM = BGM1;
    }

    public void PlaySound(_soundType soundType)
    {
        if (soundType != tampBGM)
        {
            switch (soundType)
            {
                case _soundType.BGM1:
                    nowBGM = BGM1;
                    break;
                case _soundType.BGM2:
                    nowBGM = BGM2;
                    break;
                case _soundType.BGM3:
                    nowBGM = BGM3;
                    break;
                case _soundType.BGM4:
                    nowBGM = BGM4;
                    break;
                default:
                    break;
            }

            tampBGM = soundType;
            BGM.clip = nowBGM;
            BGM.loop = true;
            BGM.Play();
        }
    }

    public void ChangeVolume(float value)
    {
        AudioListener.volume = value;
    }
}
