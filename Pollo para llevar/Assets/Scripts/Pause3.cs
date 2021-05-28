using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause3 : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject thePlayer;
    public GameObject pauseMenu;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

        thePlayer.GetComponent<FirstPersonController>().enabled = true;
        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;
        
        isPaused = false;
    }

    void Pause () {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;

        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        Cursor.visible = true;

        Cursor.lockState = CursorLockMode.None;

        isPaused = true;
    }
}
