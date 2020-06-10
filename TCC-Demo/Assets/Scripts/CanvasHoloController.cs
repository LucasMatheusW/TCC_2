using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasHoloController : MonoBehaviour
{
    public GameObject initialDisplay1;
    public GameObject mainDisplay1;
    public Holocam holocam;
    public Animals[] animals;
    public GameObject animalList;
    private int index = 0;
    private void Start() {
        initialDisplay1.SetActive(true);    
        mainDisplay1.SetActive(false);
        holocam.SetActive(false);
        foreach (var animal in animals)
        {
            animalList.transform.GetChild(animal.animalIndex).gameObject.SetActive(false);
        }
    }

    public void StartApplication()
    {
        initialDisplay1.SetActive(false);    
        mainDisplay1.SetActive(true);
        holocam.SetActive(true);
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
        holocam.cameraSpacing = animals[index].animalCameraDistance;
        holocam.target = animalList.transform.GetChild(animals[index].animalIndex);
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
}
