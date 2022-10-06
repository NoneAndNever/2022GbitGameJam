using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GrandMa2 : InteractableItem
{
    public Sprite rightHandHug;
    public Sprite leftHandHug;
    public Sprite hug;

    public Image rightHand;
    public Image leftHand;
    public bool onRight;

    public GameObject obj;
    public Transform groundPoint;
    
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
        /*if(Input.GetMouseButton(0))
        {
            //鼠标在屏幕的位置
            var obj = Physics2D.Raycast(Input.mousePosition, Vector2.zero);
            Debug.Log("鼠标点击的物体信息:" + obj.collider.gameObject.name);
        }*/
    }
    
    public void HugGitl()
    {
        imageComp.sprite = hug;
        imageComp.SetNativeSize();
        leftHand.sprite = leftHandHug;
        leftHand.SetNativeSize();
        rightHand.sprite = rightHandHug;
        rightHand.SetNativeSize();
        
        ChapterControl.Instance.PlayOneVideo("Level2End");
        obj.SetActive(false);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (onRight == false){  base.OnDrag(eventData);}
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        GameObject eventObj = eventData.pointerCurrentRaycast.gameObject;
        if(!eventObj || targetObj != eventObj) ResetPosition();
        else
        {
            onRight = true;
            Debug.Log(onRight);
            transform.position = groundPoint.position;
            originPosition = transform.position;
        }
        imageComp.raycastTarget = true;
        eventObj.GetComponent<Image>().raycastTarget = false;
    }
}