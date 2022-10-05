using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Girl1 : InteractableItem
{
    public Sprite tree;
    public Sprite ground;
    
    public Transform groundPoint;
    public GameObject hand;
    

    public enum States
    {
        OnTree,
        OnGround,
        HaveBasket
    }

    public States nowState;

    protected override void Awake()
    {
        base.Awake();
        nowState = States.OnTree;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Debug.Log(nowState);
        if (nowState != States.OnTree)
        {
            return;
        }
        base.OnDrag(eventData);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj || nowState == States.OnGround) ResetPosition();
        else
        {
            imageComp.sprite = ground;
            nowState = States.OnGround;
            transform.position = groundPoint.position;
            hand.SetActive(true);
            originPosition = transform.position;
            imageComp.SetNativeSize();
        }
        imageComp.raycastTarget = true;
        
    }

    public void GetBasket()
    {
        nowState = States.HaveBasket;
        originPosition = transform.position;
        imageComp.SetNativeSize();
        ChapterControl.Instance.PlayOneVideo();
    }

    protected override void ResetPosition()
    {
        base.ResetPosition();
        imageComp.sprite = nowState switch
        {
            States.OnTree => tree,
            States.OnGround => ground
        };
        /*switch (nowState)
        {
            case States.OnTree:
                imageComp.sprite= tree;
                break;
            case States.OnGround:
                imageComp.sprite= ground;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }*/
        imageComp.SetNativeSize();
    }
}
