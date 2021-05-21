using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_enemigos2 : MonoBehaviour
{

    public int balas_disparadas = 0;  //Balas disparadas y que le han dado al enemigo.
    public int balas_necesarias = 5; //Las balas que se necesitan para matar al enemigo.

    // Start is called before the first frame update
    void Start()
    {
        
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
                    
                    Destroy(this.gameObject);//Destruye este objeto.
                
                }
            }
        }
}