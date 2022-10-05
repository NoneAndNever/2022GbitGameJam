using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class Apple2 : InteractableItem
{
    protected override void Awake()
    {
        base.Awake();
        imageComp = GetComponent<Image>();
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            gameObject.SetActive(false);
            eventObj.GetComponent<Basket1>().AddApple();
        }
        imageComp.raycastTarget = true;
        
    }
    
}