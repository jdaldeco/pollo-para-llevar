using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using SpeechLib;

public class Colisiones : MonoBehaviour {
	public GameObject vidaTotal;
	private int puntos=0;
	private int vida=5;
	public AudioClip SonidoCoin;
	public AudioSource audiosrc;

	private SpVoice voice;
	public static string finaltext="";

	public AudioClip SonidoFinal = null;

	public AudioClip SonidoHeart = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;


	// Use this for initialization
	void Start () {
		vidaTotal = GameObject.FindWithTag ("vidaTotal");
		voice=new SpVoice();
		audiosrc = GetComponent<AudioSource>();
		Posicion = transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Método para saber las colisiones
	void OnTriggerEnter(Collider objeto){
		voice.Volume=100;
		voice.Rate = 0;
		if (objeto.gameObject.tag== "heart") {
			Debug.Log ("Toque vida");
			if(SonidoHeart) AudioSource.PlayClipAtPoint(SonidoHeart, Posicion.position, Volumen);
			Destroy (objeto.gameObject);
			vida += 5;
			vidaTotal.GetComponent<Text>().text=vida.ToString();
		}
		if (objeto.gameObject.tag=="Toad"){
			voice.Speak("Encuentra y recolecta 20 monedas para comprar un carrito", SpeechVoiceSpeakFlags.SVSFlagsAsync);
		}
		if (objeto.gameObject.tag== "chickenSpace") {
			Debug.Log ("Toque enemigo");
			vida -= 4;
			vidaTotal.GetComponent<Text>().text=vida.ToString();
		}
		if (objeto.gameObject.tag== "chickenKing") {
			Debug.Log ("Toque enemigo 2");
			vida -= 5;
			vidaTotal.GetComponent<Text>().text=vida.ToString();
		}
		if (objeto.gameObject.tag== "Ace") {
			Debug.Log ("Toque enemigo 3");
			vida -= 10;
			vidaTotal.GetComponent<Text>().text=vida.ToString();
		}
		if (objeto.gameObject.tag== "persona") {
			Debug.Log ("Toque persona");
			if(SonidoFinal) AudioSource.PlayClipAtPoint(SonidoFinal, Posicion.position, Volumen);
			Game_Win.GameWinShow();
		}
		if(vida < 1){
			//Over.show();
			GameOver.GameOverShow();
		}

	}
}
