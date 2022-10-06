using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Basket2 : InteractableItem
{
    public List<Sprite> sprites;
    public int appleTotal;
    public int apple = 0;

    public Sprite ground;

    protected override void Awake()
    {
        originPosition = null;
        imageComp = GetComponent<Image>();
    }

    private void Update()
    {
        if (originPosition == null && ChapterControl.Instance.afterPlaying)
        {
            originPosition = transform.position;
        }
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if(false)
            base.OnDrag(eventData);
    }

    public void AddApple()
    {
        imageComp.sprite = sprites[apple++];
        imageComp.SetNativeSize();
    }
    
    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj || apple != appleTotal) ResetPosition();
        else
        {
            imageComp.sprite = ground;
            imageComp.SetNativeSize();
            originPosition = transform.position;
        }
        imageComp.raycastTarget = true;
        
    }
    
}