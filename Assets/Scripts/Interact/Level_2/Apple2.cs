using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class Apple2 : InteractableItem
{
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
            gameObject.SetActive(false);
            eventObj.GetComponent<Basket2>().AddApple();
        }
        imageComp.raycastTarget = true;
        
    }
    
}