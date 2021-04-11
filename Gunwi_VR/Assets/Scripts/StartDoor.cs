using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoor : Interactable
{
    public override void Pressed()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        bool flip = renderer.enabled;

        renderer.enabled = flip;

        ViewerManager.Instance.StartView();
        ViewerManager.Instance.clickSound();
    }
}
