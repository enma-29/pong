using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Final : MonoBehaviour
{   AudioSource FuenteDeAudio;
    public Text Titulo;  
    public AudioClip fin;
    private int contGD, contGI; 
    // Start is called before the first frame update
    void Start()
    {   
      /*   Bola variable = GetComponent<Bola>();
        contGD = variable.golesDerecha; */
        
           FuenteDeAudio= GetComponent<AudioSource>();
        FuenteDeAudio.clip = fin;
        FuenteDeAudio.Play();
       
        
            Titulo.text = "Game Over";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
