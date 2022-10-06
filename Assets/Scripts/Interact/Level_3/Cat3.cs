using UnityEngine;
using UnityEngine.EventSystems;

public class Cat3 : InteractableItem
{
    
    public Sprite lick;
    
    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj || !eventObj.GetComponent<Cup>().onRight) ResetPosition();
        else
        {
            imageComp.sprite = lick;
            originPosition = transform.position;
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