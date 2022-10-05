using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterControl : MonoBehaviour
{
    public Animator _animator;

    public GameObject oneInteract;
    public GameObject onePlayer;

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
        onePlayer.SetActive(true);
        oneInteract.SetActive(false);
        _animator.Play(anim);
    }


    public void LoadScene(String scene)
    {
        SceneManager.LoadScene(scene);
    }
}