using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMgr : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CargarNivel(string NombreNivel){
		SceneManager.LoadScene(NombreNivel);
	}

	public void Salir() {
		Application.Quit();
		Debug.Log("Saliste del juego");
	}

}
