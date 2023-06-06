using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXClickPlay : MonoBehaviour
{

    public AudioSource audioo;
   
    public void ClickAudio()
    {
        audioo.Play();
    }
}
