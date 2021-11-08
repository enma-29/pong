using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    //velocidad
    public float velocidad=30.0f;

    //Eje vertical
    public string Eje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    
    }
    
     void FixedUpdate() {
         //capturo el valor del eje vertical 
         float v = Input.GetAxisRaw(Eje);
         //modificacion de la velocidad para la raqueta
         GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * velocidad);
        
    }
}
