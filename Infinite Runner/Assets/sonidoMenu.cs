using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoMenu : MonoBehaviour
{

   
    public AudioSource sound;
    public AudioClip soundMenu;
    
    public void SoundButton()
    {
        sound.clip = soundMenu;
        sound.enabled = false;
        sound.enabled = true;
    }
}
