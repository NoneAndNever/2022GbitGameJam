using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Parent : InteractableItem
{
    public Sprite stand;
    public Sprite work;
    public Vector2 position;

    public bool inPlace = false;
    
    public override void OnDrag(PointerEventData eventData)
    {
        if (!inPlace)
        {
            base.OnDrag(eventData);
            var obj = eventData.pointerCurrentRaycast.gameObject;
            if (obj)
            {
                Debug.Log(obj.name);
                //Debug.Log(transform.position);
            }
            
            imageComp.sprite = stand;
            imageComp.SetNativeSize();
        }
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            imageComp.sprite = stand;
            originPosition = transform.position;
            transform.position = position;
            imageComp.SetNativeSize();
            inPlace = !inPlace;
            //this.enabled = false;
        }
        imageComp.raycastTarget = true;
        
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.sprite = work;
        imageComp.SetNativeSize();
    }
}