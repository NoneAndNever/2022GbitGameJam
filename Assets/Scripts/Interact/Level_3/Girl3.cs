using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Girl3 : InteractableItem
{
    public Sprite happy;
    public Transform groundPoint;
    
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
    
    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            imageComp.sprite = happy;
            transform.position = groundPoint.position;
            originPosition = transform.position;
            imageComp.SetNativeSize();
            eventObj.GetComponent<Image>().raycastTarget = false;
        }
        imageComp.raycastTarget = true;
        
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.SetNativeSize();
    }
}
