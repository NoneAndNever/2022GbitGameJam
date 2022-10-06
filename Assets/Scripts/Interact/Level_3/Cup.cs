using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Cup : InteractableItem
{
    public bool onRight;
    
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
        if(!onRight) base.OnDrag(eventData);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            originPosition = transform.position;
            imageComp.SetNativeSize();
            eventObj.GetComponent<Image>().raycastTarget = false;
            onRight = true;
        }
        imageComp.raycastTarget = true;

    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.SetNativeSize();
    }
}
