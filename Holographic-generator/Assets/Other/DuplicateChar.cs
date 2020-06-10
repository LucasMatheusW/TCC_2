using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateChar : MonoBehaviour
{

    public GameObject target;
    public Camera cam;
    private GameObject copy_1;
    private GameObject copy_2;
    private GameObject copy_3;
    // Start is called before the first frame update
    void Start()
    {
        if(target != null && cam != null)
        {
            cam.transform.position = new Vector3(0, 0.5f, -1);
            cam.transform.eulerAngles = new Vector3(0, 0, 0);
            cam.transform.localScale = new Vector3(1, 1, 1);

            target.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y+0.3f, cam.transform.position.z+3f);
            target.transform.eulerAngles = cam.transform.eulerAngles;

            copy_1 = Instantiate(target);
            copy_1.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y-0.3f, target.transform.position.z);
            copy_1.transform.eulerAngles = new Vector3(180, 0, 0);
            copy_1.transform.localScale = target.transform.localScale;

            copy_2 = Instantiate(target);
            copy_2.transform.position = new Vector3(cam.transform.position.x+0.3f, cam.transform.position.y, target.transform.position.z);
            copy_2.transform.eulerAngles = new Vector3(90, 0, -90);
            copy_2.transform.localScale = target.transform.localScale;

            copy_3 = Instantiate(target);
            copy_3.transform.position = new Vector3(cam.transform.position.x-0.3f, cam.transform.position.y, target.transform.position.z);
            copy_3.transform.eulerAngles = new Vector3(90, 0, 90);
            copy_3.transform.localScale = target.transform.localScale;
        }
    }

    // Update is called once per frame
    void Update()
    {}
}
