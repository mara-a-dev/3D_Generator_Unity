using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveShape_script : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cone;
    float placementY = 20;
    float placementX = -80;
    float placementZ = 75;

    public void saveShape()
    {
        if (cube.active)
        {
            GameObject cloneCube;
            if (placementY == 90)
            {
                placementY = 20;
                placementX = placementX + 10;
                cloneCube = (GameObject)Instantiate(cube, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
                Debug.Log("Generaor : cube0" + placementY);
            }
            else
            {
                cloneCube = (GameObject)Instantiate(cube, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            Debug.Log("Generaor : cube1" + placementY);
            cloneCube.GetComponent<RotateShape_script>().enabled = false;
            cloneCube.transform.localScale += new Vector3(-15.0f, -15.0f, -15.0f);
            placementY = placementY + 10;
            Debug.Log("Generaor : cube" + placementY);
        }

        if (sphere.active)
        {
            GameObject cloneSphere;
            if (placementY == 90)
            {
                placementY = 20;
                placementX = placementX + 10;
                cloneSphere = (GameObject)Instantiate(sphere, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
                Debug.Log("Generaor : sphere0" + placementY);
            }
            else
            {
                cloneSphere = (GameObject)Instantiate(sphere, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            Debug.Log("Generaor : sphere1" + placementY);
            cloneSphere.GetComponent<RotateShape_script>().enabled = false;
            cloneSphere.transform.localScale += new Vector3(-20.0f, -20.0f, -20.0f);
            placementY = placementY + 10;
            Debug.Log("Generaor : sphere" + placementY);
        }

        if (cone.active)
        {
            GameObject cloneCone;
            if (placementY == 90)
            {
                placementY = 20;
                placementX = placementX + 10;
                cloneCone = (GameObject)Instantiate(cone, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
                Debug.Log("Generaor : cone0" + placementY);
            }
            else
            {
                cloneCone = (GameObject)Instantiate(cone, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            Debug.Log("Generaor : cone1" + placementY);
            cloneCone.GetComponent<RotateShape_script>().enabled = false;
            cloneCone.transform.localScale += new Vector3(-30.0f, -30.0f, -30.0f);
            placementY = placementY + 10;
            Debug.Log("Generaor : cone" + placementY);
        }
    }
}