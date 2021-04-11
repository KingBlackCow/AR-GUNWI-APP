using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);        
    }

    void OnCollisionEnter(Collision otehrs)
    {
        Destroy(gameObject);
    }
}
