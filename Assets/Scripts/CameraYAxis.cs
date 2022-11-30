using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraYAxis : MonoBehaviour
{
    float rotation = 0;

    // Update is called once per frame
    void Update()
    {
        rotation -= Input.GetAxis("Mouse Y");
        rotation = Mathf.Clamp(rotation, -65, 70);
        transform.localRotation = Quaternion.Euler(rotation, 0, 0);
    }
}
