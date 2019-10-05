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
            Material cubeMat;
            cubeMat = cube.GetComponent<Renderer>().material;

            if (placementY == 90)
            {
                placementY = 20;
                placementX = placementX + 10;
                cloneCube = (GameObject)Instantiate(cube, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            else
            {
                cloneCube = (GameObject)Instantiate(cube, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            cloneCube.GetComponent<Renderer>().material.color = cubeMat.color;
            cloneCube.GetComponent<RotateShape_script>().enabled = false;
            cloneCube.transform.localScale += new Vector3(-15.0f, -15.0f, -15.0f);
            placementY = placementY + 10;
        }

        if (sphere.active)
        {
            GameObject cloneSphere;
            Material sphereMat;
            sphereMat = sphere.GetComponent<Renderer>().material;

            if (placementY == 90)
            {
                placementY = 20;
                placementX = placementX + 10;
                cloneSphere = (GameObject)Instantiate(sphere, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            else
            {
                cloneSphere = (GameObject)Instantiate(sphere, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            cloneSphere.GetComponent<Renderer>().material.color = sphereMat.color;
            cloneSphere.GetComponent<RotateShape_script>().enabled = false;
            cloneSphere.transform.localScale += new Vector3(-20.0f, -20.0f, -20.0f);
            placementY = placementY + 10;
        }

        if (cone.active)
        {
            GameObject cloneCone;
            Material coneMat;
            coneMat = cone.GetComponent<Renderer>().material;

            if (placementY == 90)
            {
                placementY = 20;
                placementX = placementX + 10;
                cloneCone = (GameObject)Instantiate(cone, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            else
            {
                cloneCone = (GameObject)Instantiate(cone, new Vector3(placementX, 50 - placementY, placementZ + 10), Quaternion.identity);
            }
            cloneCone.GetComponent<Renderer>().material.color = coneMat.color;
            cloneCone.GetComponent<RotateShape_script>().enabled = false;
            cloneCone.transform.localScale += new Vector3(-30.0f, -30.0f, -30.0f);
            placementY = placementY + 10;
        }
    }
}