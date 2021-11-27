using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discolights : MonoBehaviour
{
    public GameObject blue;
    public GameObject green;
    public GameObject purple;
    private bool alternate = true;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    void switchLight()
    {
        if (alternate)
        {
            blue.SetActive(false);
            green.SetActive(true); 
            purple.SetActive(true);
            alternate = false;
        }
        else
        {
            green.SetActive(false);
            purple.SetActive(false);
            blue.SetActive(true);
            alternate = true;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (counter >= 300)
        {
            switchLight();
            counter = 0;
        }
        counter++;
    }
}
