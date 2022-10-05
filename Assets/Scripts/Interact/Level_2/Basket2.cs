using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Basket2 : InteractableItem
{
    public List<Sprite> sprites;
    public int appleTotal;
    public int apple = 0;

    public Sprite ground;

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