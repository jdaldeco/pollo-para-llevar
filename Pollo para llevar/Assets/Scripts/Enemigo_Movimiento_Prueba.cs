using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo_Movimiento_Prueba : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject target;
    bool cerca;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        goToTarget();
    }

    private void goToTarget() {
        if (cerca) agent.SetDestination(target.transform.position);
    }

    //Método para saber las colisiones
	void OnTriggerEnter(Collider objeto){
		
		if (objeto.gameObject.tag == "Player") {
			Debug.Log ("Player cerca");
            cerca = true;
            goToTarget();
		}
	}

    void OnTriggerExit(Collider objeto) {
        if (objeto.gameObject.tag == "Player") {
			Debug.Log ("Player cerca");
            cerca = false;
            goToTarget();
		}
    }
}