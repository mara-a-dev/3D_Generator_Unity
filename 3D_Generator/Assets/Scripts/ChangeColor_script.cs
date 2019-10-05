using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor_script : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cone;
    public void changeColor()
    {
        Color color = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
        if (cube.active)
            cube.GetComponent<Renderer>().material.color = color;
        if (sphere.active)
            sphere.GetComponent<Renderer>().material.color = color;
        if (cone.active)
            cone.GetComponent<Renderer>().material.color = color;
    }
}