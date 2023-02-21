using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Help_Button : MonoBehaviour
{
    
    public GameObject Tutorial;

    public bool State = false;

    public AudioSource Help_Button_Sound;


    public void onclick_Button()
    {
        Help_Button_Sound.Play();
        if(State == false)
        {
            State = true;
            //open karo
            Tutorial.gameObject.GetComponent<Animator>().SetTrigger("Open");
        }
        else if(State == true)
        {
            //close karo
            State=false;
            Tutorial.gameObject.GetComponent<Animator>().SetTrigger("Close");
        }
    }
}
