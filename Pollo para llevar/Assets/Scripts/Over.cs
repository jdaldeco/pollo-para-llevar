using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
        public GameObject Instrucciones1Text;
    public static GameObject Instrucciones1Static;

    public GameObject Instrucciones2Text;
    public static GameObject Instrucciones2Static;

    // Start is called before the first frame update
    void Start()
    {
        Over.Instrucciones1Static = Instrucciones1Text;
        Over.Instrucciones1Static.gameObject.SetActive(true);

        Over.Instrucciones2Static = Instrucciones2Text;
        Over.Instrucciones2Static.gameObject.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void showGanar(){
        
    }

    public static void showInstrucciones1_off(){
        Over.Instrucciones1Static.gameObject.SetActive(false);
    }

    public static void showInstrucciones2(){
        Over.Instrucciones2Static.gameObject.SetActive(true);
    }

    
}
