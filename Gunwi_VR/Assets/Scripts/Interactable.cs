using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int index = 0;

    public virtual void Pressed()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        bool flip = renderer.enabled;

        renderer.enabled = flip;

        ViewerManager.Instance.LoadNextView(index);
        ViewerManager.Instance.clickSound();
    }
}
