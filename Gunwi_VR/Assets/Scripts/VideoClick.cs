using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoClick : Interactable
{
    public override void Pressed()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        bool flip = renderer.enabled;

        renderer.enabled = flip;

        ViewerManager.Instance.LoadVideo(index);
        ViewerManager.Instance.clickSound();
    }
}
