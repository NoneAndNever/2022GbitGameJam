using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Girl1 : InteractableItem
{
    public Sprite air;
    public Sprite tree;
    public Sprite ground;
    public SpriteRenderer spriteRenderer;

    protected override void Awake()
    {
        base.Awake();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected override void OnMouseUp()
    {
        base.OnMouseUp();
        spriteRenderer.sprite = ground;
    }

    protected override void OnMouseDrag()
    {
        base.OnMouseDrag();
        spriteRenderer.sprite = air;
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        spriteRenderer.sprite = tree;
    }
}
