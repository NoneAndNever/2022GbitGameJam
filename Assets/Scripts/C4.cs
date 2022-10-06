using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C4 : MonoBehaviour
{
    public Parent mom;
    public Parent dad;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (mom.inPlace && dad.inPlace)
        {
            mom.enabled = false;
            dad.enabled = true;
            anim.Play("End");
            
        }
    }
}
