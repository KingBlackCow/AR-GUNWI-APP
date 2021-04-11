using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : Interactable
{
    public override void Pressed()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        bool flip = renderer.enabled;

        renderer.enabled = flip;

        gameObject.SetActive(false);
        //ViewerManager.Instance.StartView(0);
        ViewerManager.Instance.LoadNextView(0);
        ViewerManager.Instance.clickSound();
    }
}
