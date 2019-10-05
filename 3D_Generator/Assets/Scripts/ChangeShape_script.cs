using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape_script : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cone;

    public void getRandomShape()
    {
        int x = Random.Range(0, 3);
        switch (x)
        {
            case 0:
                Debug.Log("Generator : cube");
                if (!cube.active)
                    cube.SetActive(true);
                if (sphere.active)
                    sphere.SetActive(false);
                if (cone.active)
                    cone.SetActive(false);
                break;
            case 1:
                Debug.Log("Generator : cone");
                if (cube.active)
                    cube.SetActive(false);
                if (sphere.active)
                    sphere.SetActive(false);
                if (!cone.active)
                    cone.SetActive(true);
                break;
            case 2:
                Debug.Log("Generator : sphere");
                if (cube.active)
                    cube.SetActive(false);
                if (!sphere.active)
                    sphere.SetActive(true);
                if (cone.active)
                    cone.SetActive(false);
                break;
        }
    }
}