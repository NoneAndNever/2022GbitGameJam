using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Girl2 : InteractableItem
{
    public Sprite hug;
    
    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            imageComp.sprite = hug;
            originPosition = transform.position;
            eventObj.GetComponent<GrandMa2>().HugGitl();
            imageComp.SetNativeSize();
        }
        imageComp.raycastTarget = true;
        
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.SetNativeSize();
    }
}
