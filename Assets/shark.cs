using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;


    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        height = 4;
        width = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0;

        transform.position = new Vector3(x, y, z);
        
    }
}
