using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        float offset_x = 0.8f;
        float offset_y = 0.8f;
        
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        float newPos_x = mousePos.x + offset_x;
        float newPos_y = mousePos.y + offset_y;
        transform.position = new Vector3(newPos_x, newPos_y, mousePos.z);
    }
}
