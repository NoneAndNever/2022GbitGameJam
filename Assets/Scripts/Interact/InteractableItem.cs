using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InteractableItem : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{

    [SerializeField] private Vector3 originPosition;
    public Image imageComp;
    [SerializeField] protected GameObject targetObj;//需要交互的物体

    protected virtual void Awake()
    {
        imageComp = GetComponent<Image>();
        originPosition = transform.position;
    }
    

    protected virtual void ResetPosition()
    {
        transform.position = originPosition;
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public virtual void OnBeginDrag(PointerEventData eventData)
    {
        ;
    }

    public virtual void OnEndDrag(PointerEventData eventData)
    {
        /*GameObject eventGameObj = eventData.pointerCurrentRaycast.gameObject;*/
        
    }
}
