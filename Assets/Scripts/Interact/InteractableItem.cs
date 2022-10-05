using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    private static Camera mainCam;
    private static Vector3 camOffset =new Vector3(0, 0, 10);
    [SerializeField] private Vector3 originPosition;
    [SerializeField] protected Collider2D col;
    [SerializeField] protected Collider2D targetCol;

    protected virtual void Awake()
    {
        mainCam=Camera.main;
        col = GetComponent<Collider2D>();
        originPosition = transform.position;
    }

    protected virtual  void OnMouseDrag()
    {
        transform.position = mainCam.ScreenToWorldPoint(Input.mousePosition + camOffset);
    }

    protected virtual void OnMouseUp()
    {
        if (!targetCol.OverlapPoint(transform.position))
        {
            ResetPosition();
        }
    }

    protected virtual void ResetPosition()
    {
        transform.position = originPosition;
    }
}
