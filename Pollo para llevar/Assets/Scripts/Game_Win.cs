using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Win : MonoBehaviour
{

    public GameObject thePlayer;

    public GameObject canvasGameWin;
    public static GameObject canvasGameWinStatic;


    // Start is called before the first frame update
    void Start()
    {
        Game_Win.canvasGameWinStatic = canvasGameWin;
        Game_Win.canvasGameWinStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void GameWinShow(){
        Game_Win.canvasGameWinStatic.gameObject.SetActive(true);
        Time.timeScale = 0;
        //GameOver.thePlayer.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void CargarNivel(string NombreNivel){
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
		SceneManager.LoadScene(NombreNivel);
	}

	public void Salir() {
		Application.Quit();
		Debug.Log("Saliste del juego");
	}

}
