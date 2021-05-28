using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SwitchToLvl3 : MonoBehaviour
{

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

    void OnTriggerEnter() {
        if(Sonido) AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
        SceneManager.LoadScene(7);
    }
}
