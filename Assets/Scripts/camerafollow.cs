using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    private Transform playertransform;
    public float offset;
    void Start()
    {
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

 
    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = playertransform.position.x+offset;
        temp.y = playertransform.position.y+offset  ;


        transform.position = temp;
    }
}
