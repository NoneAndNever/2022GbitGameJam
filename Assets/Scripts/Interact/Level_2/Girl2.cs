using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Girl2 : InteractableItem
{
    public Sprite hug;

    public Image hand;
    public Sprite hugHand;
    public Basket2 basket2;
    
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
        base.OnDrag(eventData);
        var obj = eventData.pointerCurrentRaycast.gameObject;
        if (obj)
        {
            Debug.Log(obj.gameObject);
        }
        
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj || !eventObj.GetComponent<GrandMa2>().onRight || basket2.apple != basket2.appleTotal) ResetPosition();
        else
        {
            imageComp.sprite = hug;
            originPosition = transform.position;
            hand.sprite = hugHand;
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
