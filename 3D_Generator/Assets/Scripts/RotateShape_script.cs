using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateShape_script : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Time.deltaTime * 50, 0, 0);
        transform.Rotate(0, Time.deltaTime * 50, 0, 0);
    }
}