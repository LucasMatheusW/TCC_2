using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Rotate : MonoBehaviour
{
    public Transform target;
    private int angleY;

    void Start()
    {
        angleY = 0;
    }

    void Update()
    {
        if(target != null)
        {
            Vector3 rotation = new Vector3(target.eulerAngles.x, angleY, target.eulerAngles.z);
            target.eulerAngles = rotation;
            angleY++;
        }
    }
}