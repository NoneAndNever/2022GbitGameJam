using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Basket1 : InteractableItem
{
    public List<Sprite> sprites;
    public int appleTotal;
    private int apple = 0;
    public Transform basketPoint;

    protected override void Awake()
    {
        base.Awake();
        Debug.Log(originPosition);
        
    }

    public void AddApple()
    {
        imageComp.sprite = sprites[apple++];
        imageComp.SetNativeSize();
    }
    
    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj || apple != appleTotal || eventObj.GetComponent<Girl1>().nowState != Girl1.States.OnGround) ResetPosition();
        else
        {
            transform.position = basketPoint.position;
            originPosition = transform.position;
            Debug.Log(originPosition);
            eventObj.GetComponent<Girl1>().GetBasket();
        }
        imageComp.raycastTarget = true;
        
    }
    
}