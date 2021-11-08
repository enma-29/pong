using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        //si pulsa la tecla P o clic izquierdo inicia el juego
        if(Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0)){
            //Cargo la escena del juego
            SceneManager.LoadScene("juego");
        }

    }
}
