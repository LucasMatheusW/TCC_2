using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasNormalController : MonoBehaviour
{
    public CameraNormalController cameraController;
    public Rotate rotationController;
    public GameObject mainDisplay1;
    public Animals[] animals;
    public GameObject animalList;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var animal in animals)
        {
            animalList.transform.GetChild(animal.animalIndex).gameObject.SetActive(false);
        }
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

    public void PreviousAnimal()
    {
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(false);
        index -= 1;
        animalList.transform.GetChild(animals[index].animalIndex).gameObject.SetActive(true);
        Reload();
    }

    private void Reload()
    {
        if(index == 0)
        {
            mainDisplay1.transform.GetChild(1).GetComponent<Button>().enabled = false;
        }
        else
        {
            mainDisplay1.transform.GetChild(1).GetComponent<Button>().enabled = true;
        }

        if(index == animals.Length-1)
        {
            mainDisplay1.transform.GetChild(0).GetComponent<Button>().enabled = false;
        }
        else
        {
            mainDisplay1.transform.GetChild(0).GetComponent<Button>().enabled = true;
        }
        mainDisplay1.transform.GetChild(2).GetComponent<Text>().text = animals[index].text;
        cameraController.target = animalList.transform.GetChild(animals[index].animalIndex);
        rotationController.target = animalList.transform.GetChild(animals[index].animalIndex);
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
