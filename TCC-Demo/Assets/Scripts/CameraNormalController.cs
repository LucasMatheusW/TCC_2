using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraNormalController : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
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

    private void FollowTarget()
    {
        float posY = target.transform.position.y + 1f;
        float posX = target.transform.position.x + 5f;
        float posZ = target.transform.position.z - 5f;

        this.transform.position = new Vector3(posX, posY, posZ);
        this.transform.eulerAngles = new Vector3(0,310f,0);
    }
}
