using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Girl1 : InteractableItem
{
    public Sprite air;
    public Sprite tree;
    public Sprite ground;


    protected override void Awake()
    {
        base.Awake();
        imageComp = GetComponent<Image>();
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        imageComp.sprite = air;
        imageComp.SetNativeSize();
        imageComp.raycastTarget = false;
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj||targetObj!=eventObj) ResetPosition();
        else
        {
            imageComp.sprite = ground;
            imageComp.SetNativeSize();
        }
        imageComp.raycastTarget = true;
        
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.sprite= tree;
        imageComp.SetNativeSize();
    }
}
