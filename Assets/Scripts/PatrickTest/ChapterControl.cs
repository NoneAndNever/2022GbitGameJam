using System.Collections.Generic;
using UnityEngine;

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
            DontDestroyOnLoad(Instance);
        }
        else Destroy(Instance);
    }

    public void PlayOneVideo()
    {
        onePlayer.SetActive(true);
        oneInteract.SetActive(false);
        _animator.Play("Chapter_1");
    }
}