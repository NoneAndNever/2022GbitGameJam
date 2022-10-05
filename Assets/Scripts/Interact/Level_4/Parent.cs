using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Parent : InteractableItem
{
    public Sprite total;
    public Sprite half;

    public bool inPlace = false;
    
    public override void OnDrag(PointerEventData eventData)
    {
        if (!inPlace)
        {
            base.OnDrag(eventData);
            imageComp.sprite = total;
        }
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            imageComp.sprite = half;
            originPosition = transform.position;
            imageComp.SetNativeSize();
            inPlace = !inPlace;
        }
        imageComp.raycastTarget = true;
        
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.sprite = half;
        imageComp.SetNativeSize();
    }
}