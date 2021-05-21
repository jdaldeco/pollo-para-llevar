using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using SpeechLib;

public class Colisiones : MonoBehaviour {
	public GameObject vidaTotal;
	private int puntos=0;
	private int vida=0;
	public AudioClip SonidoCoin;

	private SpVoice voice;
	public static string finaltext="";

	// Use this for initialization
	void Start () {
		vidaTotal = GameObject.FindWithTag ("vidaTotal");
		voice=new SpVoice();
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
			gameObject.GetComponent<AudioSource> ().PlayOneShot (SonidoCoin, 0.7f);
			Destroy (objeto.gameObject);
			vida += 5;
			vidaTotal.GetComponent<Text>().text=vida.ToString();
		}
		if (objeto.gameObject.tag=="Toad"){
			voice.Speak("Encuentra y recolecta 20 monedas para comprar un carrito", SpeechVoiceSpeakFlags.SVSFlagsAsync);
		}
	}
}
