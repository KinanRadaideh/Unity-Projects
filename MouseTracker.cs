using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArabicSupport;

public class MouseTracker : MonoBehaviour
{
    
    [SerializeField] private Camera mainCamera;
    // Update is called once per frame
    public void Update()
    {
        Vector3 vector3mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        vector3mousePosition.z = 0;
        Debug.Log(vector3mousePosition);
        transform.position = new Vector3(vector3mousePosition.x, vector3mousePosition.y, vector3mousePosition.z);

    }
}
