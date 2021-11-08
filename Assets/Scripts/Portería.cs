using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portería : MonoBehaviour
{
    //detectar si la bola atraviesa la porteria
    void OnTriggerEnter2D(Collider2D bola){
        if(bola.name == "Bola"){
            //si es la porteria izquierda
            if(this.name == "izquierda"){
    
                bola.GetComponent<Bola>().reiniciarBola("Derecha");
            }
            else if(this.name == "Derecha"){
                bola.GetComponent<Bola>().reiniciarBola("Izquierda");
               
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
