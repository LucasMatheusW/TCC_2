using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Crosstales.RTVoice;
using Crosstales.RTVoice.Model.Enum;

public class DialogController : MonoBehaviour
{
    public bool loaded;
    void Start()
    {
        DontDestroyOnLoad(this);       
    }

    void Update() {
        if(Speaker.areVoicesReady && Speaker.isTTSAvailable)
        {
            loaded = true;
        } 
        else
        {
            loaded = false;
        }
    }

    public void Say(string text)
    {
        if(loaded)
        {
            Speaker.Speak(text, null, Speaker.VoiceForGender(Crosstales.RTVoice.Model.Enum.Gender.FEMALE, "pt-BR"));
        }
    }
}
