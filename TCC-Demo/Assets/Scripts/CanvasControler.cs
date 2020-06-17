using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasControler : MonoBehaviour
{
    public enum RenderKind {
        HOLOGRAPHIC,
        NORMAL,
        XR
    }

    public Button btnNext;
    public Button btnPrev;
    public Text text;
    public RenderKind renderKind;
    [ShowWhen("renderKind", ShowWhenAttribute.Condition.Equals, 0)]
    public Holocam holocam;
    [ShowWhen("renderKind", ShowWhenAttribute.Condition.Equals, 0)]
    public GameObject initialDisplay1;
    [ShowWhen("renderKind", ShowWhenAttribute.Condition.NotEquals, 0)]
    public CameraNormalController cameraController;
    [ShowWhen("renderKind", ShowWhenAttribute.Condition.NotEquals, 0)]
    public Rotate rotationController;
    public Animals[] animals;
    public GameObject animalList;
    private int index = 0;
    private void Start() {
        if(renderKind == RenderKind.HOLOGRAPHIC)
        {
            initialDisplay1.SetActive(true);
            holocam.SetActive(false);
            btnNext.enabled = false;
            btnPrev.enabled = false;
            text.enabled = false;
        }
        foreach (var animal in animals)
        {
            animalList.transform.GetChild(animal.animalIndex).gameObject.SetActive(false);
        }
        if(renderKind != RenderKind.HOLOGRAPHIC)
        {
            StartApplication();
        }
    }

    public void StartApplication()
    {
        if(renderKind == RenderKind.HOLOGRAPHIC)
        {
            holocam.SetActive(true);
            initialDisplay1.SetActive(false);
            btnNext.enabled = true;
            btnPrev.enabled = true;
            text.enabled = true;
        } 
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(true);
        Reload();
    }

    private void Reload()
    {
        btnPrev.enabled = (index == 0 ? false : true);
        btnNext.enabled = (index == animals.Length-1 ? false : true);
        
        text.text = animals[index].text;
        if(renderKind == RenderKind.HOLOGRAPHIC)
        {
            holocam.cameraSpacing = animals[index].animalCameraDistance;
            holocam.target = animalList.transform.GetChild(animals[index].animalIndex);
        }
        else 
        {
            cameraController.target = animalList.transform.GetChild(animals[index].animalIndex);
            rotationController.target = animalList.transform.GetChild(animals[index].animalIndex);
        }
    }

    public void PreviousAnimal()
    {
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(false);
        index -= 1;
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(true);
        Reload();
    }

    public void NextAnimal()
    {
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(false);
        index += 1;
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(true);
        Reload();
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Speak()
    {
        GameObject.FindGameObjectWithTag("Dialog").GetComponent<DialogController>().Say(animals[index].text);
    }
}
