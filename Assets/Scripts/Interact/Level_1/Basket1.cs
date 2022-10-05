using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Basket1 : InteractableItem
{
    public List<Sprite> sprites;
    public int apple; 

    public SpriteRenderer spriteRenderer;

    protected override void Awake()
    {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        spriteRenderer.sprite = sprites[++apple];
    }



}