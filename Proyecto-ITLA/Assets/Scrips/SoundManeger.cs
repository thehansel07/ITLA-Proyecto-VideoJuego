using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManeger : MonoBehaviour
{
    [SerializeField] AudioClip disparoSonido;
    private AudioSource src;
    void Start()
    {
        src = GetComponent<AudioSource>();
        
    }

    public void PlaySound(){
        src.PlayOneShot(disparoSonido);


    }


}
