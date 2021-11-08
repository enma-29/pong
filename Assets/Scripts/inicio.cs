using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicio : MonoBehaviour
{
    AudioSource FuenteDeAudio;
    public AudioClip Nicio;
    // Start is called before the first frame update
    void Start()
    {
        FuenteDeAudio= GetComponent<AudioSource>();
        FuenteDeAudio.clip = Nicio;
        FuenteDeAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
