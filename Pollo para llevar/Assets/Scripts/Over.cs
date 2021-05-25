using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    public GameObject GameOverText;
    public static GameObject GameOverStatic;

    public GameObject GameOverText2;
    public static GameObject GameOverStatic2;

    // Start is called before the first frame update
    void Start()
    {
        Over.GameOverStatic = GameOverText;
        Over.GameOverStatic.gameObject.SetActive(false);

        Over.GameOverStatic2 = GameOverText2;
        Over.GameOverStatic2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void show(){
        Over.GameOverStatic.gameObject.SetActive(true);
    }

    public static void showGanar(){
        Over.GameOverStatic2.gameObject.SetActive(true);
    }
}
