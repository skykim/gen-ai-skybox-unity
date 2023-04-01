using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float rotationXOffset = 1.0f;
    public float rotationYOffset = 1.0f;

    public GameObject npcObject;

    void Update()
    {
        transform.eulerAngles += rotationXOffset * Vector3.left;
        transform.eulerAngles += rotationYOffset * Vector3.up;
        
        npcObject.transform.localEulerAngles += rotationXOffset * Vector3.left;
        npcObject.transform.localEulerAngles += rotationYOffset * Vector3.up;
    }
}
