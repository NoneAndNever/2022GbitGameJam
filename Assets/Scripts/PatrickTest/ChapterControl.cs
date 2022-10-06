using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterControl : MonoBehaviour
{
    public Animator _animator;

    public bool afterPlaying;

    public static ChapterControl Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlayOneVideo(String anim)
    {
        _animator.Play(anim);
    }


    public void LoadScene(String scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void SetPlaying(bool afterPlaying)
    {
        this.afterPlaying = afterPlaying;
    }
}