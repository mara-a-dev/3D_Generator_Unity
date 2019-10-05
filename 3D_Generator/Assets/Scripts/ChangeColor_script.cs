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
        if (cube.active)
            cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        if (sphere.active)
            sphere.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        if (cone.active)
            cone.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}