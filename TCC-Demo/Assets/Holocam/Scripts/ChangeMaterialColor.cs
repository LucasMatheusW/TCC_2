using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rd;
    private float timer;
    private float changeTime = 1.0f;
    private float hue = 0.0f;
    void Start()
    {
        rd.material.color = new Color(0,0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > changeTime)
        {
            if(hue < 1.0f)
            {
                hue += 0.01f;
            } 
            else
            {
                hue = 0.0f;
            }
            timer = 0.0f;
        }
        rd.material.color = Color.HSVToRGB(hue,1,1);
    }
}
