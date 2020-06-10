using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private bool hasSpoken = false;
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadHoloScene()
    {
        SceneManager.LoadScene("HolographicScene");
    }

    public void LoadNormalScene()
    {
        SceneManager.LoadScene("NormalScene");
    }


    public void LoadXRScene()
    {
        SceneManager.LoadScene("XRScene");
    }

    void Update()
    {
        DialogController dc = GameObject.FindGameObjectWithTag("Dialog").GetComponent<DialogController>();
        if(dc.loaded && !hasSpoken)
        {
            dc.Say("Demo holografia");
            hasSpoken = true;
        }
    }
}
