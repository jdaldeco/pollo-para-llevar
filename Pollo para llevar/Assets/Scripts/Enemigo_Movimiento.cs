using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo_Movimiento : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject target;

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
        agent.SetDestination(target.transform.position);
    }
}
