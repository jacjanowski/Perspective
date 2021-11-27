using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copLights : MonoBehaviour
{
    public GameObject blue;
    public GameObject red;
    private bool alternate = true;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void switchLight(){
        if(alternate){
            blue.SetActive(false);
            red.SetActive(true);
            alternate = false;
        }
        else{
            red.SetActive(false);
            blue.SetActive(true);
            alternate = true;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if(counter >= 300){
            switchLight();
            counter = 0;
        }
        counter++;
    }
}
