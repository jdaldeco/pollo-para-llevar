using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador2 : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed= 20; //Velocidad de la bala.

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
