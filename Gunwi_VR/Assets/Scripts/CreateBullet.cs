using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    public Transform firePosL;
    public Transform firePosR;
    public Transform bullet;
    
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTrackedRemote))
        {
            Instantiate(bullet, firePosL.position, firePosL.rotation);
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote))
        {
            Instantiate(bullet, firePosR.position, firePosR.rotation);
        }
    }
}
