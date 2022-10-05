using UnityEngine;
using UnityEngine.EventSystems;

public class GrandMa2 : InteractableItem
{
    public Sprite hug;

    public void HugGitl()
    {
        imageComp.sprite = hug;
        imageComp.SetNativeSize();
    }
}