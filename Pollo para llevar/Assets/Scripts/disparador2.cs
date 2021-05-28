using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class disparador2 : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed= 20; //Velocidad de la bala.

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
        if( Input.GetButtonDown( "Fire1" ) )//Si se pulsa el boton izquierdo del ratón.
        {
        Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                           transform.position,
                                                           transform.rotation)
                as Rigidbody;
 
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
            if(Sonido) AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
        }
    }
}
