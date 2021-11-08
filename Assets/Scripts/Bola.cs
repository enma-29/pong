using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    //public float velocidad_=30.0f;

//Audio source

AudioSource fuenteDeAudio;

//clips de audio
public AudioClip Gol, Raqueta, Rebote;


    //contador de goles
    public int golesIzquierda =0;
    public int golesDerecha =0;

    private float gol= 30f;
    //cajas de texto
    public Text contadorIzquierda, contadorDerecha;

    // Start is called before the first frame update
    void Start()
    {
        //velocidad inicial en una direccion, en este caso a la izquierda.
        GetComponent<Rigidbody2D>().velocity = Vector2.left * gol;
        
        //recupero el componente audio source
        fuenteDeAudio = GetComponent<AudioSource>();

        //Valores para los contadores en 0
        contadorDerecha.text = golesDerecha.ToString();
        contadorIzquierda.text = golesIzquierda.ToString();

    }
    //se ejecuta si choca conntra la raqueta
    void OnCollisionEnter2D(Collision2D micolision) {
        /* Col contiene toda la información de la colisión Si la bola colisiona con la raqueta:
        micolision.gameObject es la raqueta
        micolision.transform.position es la posición de la raqueta */


        //si choca contra la raqueta izquierda
        if(micolision.gameObject.name == "Raqueta Izquierda"){
            //Valor x
            int x=1;
            //valor y
            int y= direccionY(transform.position, micolision.transform.position);

            //calculo direccion con la intencion de que sea 1 o -1
            Vector2 direccion = new Vector2(x, y);
            //apliacion de la velocidad
            GetComponent<Rigidbody2D>().velocity = direccion * gol;
               
            //Reproduzco el sonido de la raqueta
            
            fuenteDeAudio.clip = Raqueta;
            fuenteDeAudio.Play();
                }
            //si choca contra la derecha
            if(micolision.gameObject.name == "Raqueta derecha"){
                //valor x
                int x =-1;
                //valor de y
                int y = direccionY(transform.position, micolision.transform.position);
                
                //calculo la direccion 
                Vector2 direccion = new Vector2 (x, y);

                //aplico velocidad
                GetComponent<Rigidbody2D>().velocity = direccion * gol;

                  //Reproduzco el sonido de la raqueta
                fuenteDeAudio.clip = Raqueta;
                fuenteDeAudio.Play();
             }
             //sonido del rebote
             if(micolision.gameObject.name == "Arriba" || micolision.gameObject.name == "Abajo"){
                 //Reproduzco el sonido del rebote
                 fuenteDeAudio.clip = Rebote;
                 fuenteDeAudio.Play();
                }  
            }
            //Calculo de la direccion Y
            int direccionY(Vector2 posicionBola, Vector2 posicionRaqueta){
                if(posicionBola.y > posicionRaqueta.y){
                    return 1;
                }
                else if(posicionBola.y < posicionRaqueta.y){
                    return -1;
                }
                else{
                        return 0;
                    }
            }

            //reinicio la posicion de la bola
            public void reiniciarBola(string direccion){
                //posicion de la bola en 0
                transform.position = Vector2.zero;
                //vector2.zero es igual a new vector2(0,0)

                //incrento el contador general de los goles para aplicarlo a la velocidad con relacion a estos
                gol +=7;
                //velocidad inicial de la bola
                /* velocidad_ = 30; */
           

                //velocidad y direccion
                if(direccion == "Derecha"){
                    //incremento los goles al de la derecha
                    golesDerecha += 1;
                    
                    //lo escribo en el marcador 
                    contadorDerecha.text = golesDerecha.ToString();

                    //reinicio la posicion de la bola 
                    GetComponent<Rigidbody2D>().velocity = Vector2.right * gol;
                    //Vector.rigth es lo mismo que new vector2D (1,0)
                }
                    else if(direccion =="Izquierda"){
                        //incrementar goles izquierda
                        golesIzquierda += 1;
                        
                        //ponerlo en el marcador
                        contadorIzquierda.text = golesIzquierda.ToString();

                        //reiniciar la bola
                        GetComponent<Rigidbody2D>().velocity = Vector2.left * gol;

                        //Vector.left es lo mismo que new vector2D (-1,0)
                    }
            //reproduzco el sonido del gol
            fuenteDeAudio.clip = Gol;
            fuenteDeAudio.Play();
         
            
                if(golesIzquierda==5 || golesDerecha==5){
                        
                           SceneManager.LoadScene("final"); 

                }
            }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
