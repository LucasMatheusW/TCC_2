using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PyramidHelperControler : MonoBehaviour
{
    public GameObject inputContainer;
    public GameObject outputContainer;
    public InputField monitorSizeField;
    public Text pyramidBase;
    public Text pyramidTop;
    public Text pyramidHeight;
    // Start is called before the first frame update
    void Start()
    {
        inputContainer.SetActive(true);
        outputContainer.SetActive(false);
    }

    public void CalcPyramidValues(){
        float divResult = int.Parse(monitorSizeField.text) / 5;

        pyramidBase.text = ((divResult * 2.5f) * 2.54f).ToString() + " cm";
        pyramidTop.text = ((divResult * 0.5f) * 2.54f).ToString() + " cm";
        pyramidHeight.text = ((divResult * 1.5f) * 2.54f).ToString() + " cm";

        inputContainer.SetActive(false);
        outputContainer.SetActive(true);
    }

    public void Return(){
        monitorSizeField.text = "";
        inputContainer.SetActive(true);
        outputContainer.SetActive(false);
    }

}
