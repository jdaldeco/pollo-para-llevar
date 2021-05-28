using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class vida_enemigos_ACE : MonoBehaviour
{

    public int balas_disparadas = 0;  //Balas disparadas y que le han dado al enemigo.
    public int balas_necesarias = 5; //Las balas que se necesitan para matar al enemigo.

    public AudioClip Sonido = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;

    // Start is called before the first frame update
    void Start()
    {
        Posicion = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
            if (other.tag == "bullet")//Si toca el tag "bullet". 
            {
                balas_disparadas += 1; //Suma 1 a las balas disparadas.
                Destroy(other.gameObject);//Destruye la bala.
                if (balas_necesarias == balas_disparadas)//Si han tocado al jugador el número de balas necesarias.
                {
                    if(Sonido) AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
                    Destroy(this.gameObject);//Destruye este objeto.
                    Over.showInstrucciones1_off();
                    Over.showInstrucciones2();
                }
            }
    }
}
