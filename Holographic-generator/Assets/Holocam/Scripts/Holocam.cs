using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Holocam : MonoBehaviour
{
    [Tooltip("Space between camera and target, or center of FOV")]
    public float cameraSpacing;
    [Tooltip("Target that the camera will follow")]
    public Transform target;
    private bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.transform;
        }
        FollowTarget();
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
    }

    void FollowTarget()
    {
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            GameObject child = this.gameObject.transform.GetChild(i).gameObject;
            float x, y, z;
            x = target.transform.position.x;
            y = target.transform.position.y;
            z = target.transform.position.z;
            if(child.tag == "FrontView")
            {
                child.transform.position = new Vector3(x, y, z + cameraSpacing);
            }
            else if(child.tag == "BackView")
            {
                child.transform.position = new Vector3(x, y, z - cameraSpacing);
            }
            else if(child.tag == "RightView")
            {
                child.transform.position = new Vector3(x - cameraSpacing, y, z);
            }
            else if(child.tag == "LeftView")
            {
                child.transform.position = new Vector3(x + cameraSpacing, y, z);
            }
            else if(child.tag == "Canvas")
            {
                for(int j = 0; j < child.transform.childCount; j++)
                {
                    GameObject gc = child.transform.GetChild(j).gameObject;
                    if(gc.tag == "MainTiles")
                    {
                        gc.SetActive(active);
                    } 
                    else if(gc.tag == "EnabledFalseTiles")
                    {
                        gc.SetActive(!active);
                    }
                }
            }
        }
    }

    public void SetActive(bool active)
    {
        this.active = active;
    }

    public void PyramidHelper(){
        SceneManager.LoadScene("PyramidHelper");
    }
}

