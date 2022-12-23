using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
    void Update()
    {
        float targetAngle = 90;
        float turnSpeed = 3;
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, targetAngle), turnSpeed*Time.deltaTime);
        }

            
    }
}
