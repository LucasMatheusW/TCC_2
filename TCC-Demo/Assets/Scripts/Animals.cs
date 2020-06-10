using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Animal", menuName="ScriptableObjects/Animals")]
public class Animals : ScriptableObject
{
    public string text;
    public int animalIndex;
    public float animalCameraDistance;
}
