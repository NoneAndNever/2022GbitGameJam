using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour
{
    public Parent mom;
    public Parent dad;
    public Animator anim;
    public GameObject pauseButton;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (mom.inPlace && dad.inPlace)
        {
            mom.enabled = false;
            dad.enabled = false;
            pauseButton.SetActive(false);
            anim.Play("End");
            
        }
    }
}
