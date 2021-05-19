using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.7f, 0, Space.World);
    }
}
