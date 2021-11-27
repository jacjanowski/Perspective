using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCan : MonoBehaviour
{
    public GameObject can;
    public int arg;
    private Vector3 canPos;
    private GameObject canObject;
    private int canCreated = 0;

    public void spawnOrDestroy(int num){
        arg = num;
    }

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(arg == 0){
            canCreated = 0;
            if(canObject != null){
                Destroy(canObject);
            }
        }
        else{
            // Instantiate at position (0, 0, 0) and zero rotation.
            if(canCreated == 0){
                canObject = Instantiate(can, new Vector3(-5.8f, -1.65f, -7.0f), Quaternion.identity);
                canObject.transform.Rotate(0,0,90);
                canCreated = 1;
            }
            if(canObject != null){
                canPos = canObject.transform.position;
                Debug.Log(canPos);
                if(canPos.z < -4.5){
                    canPos.z += 0.0025f;
                    canObject.transform.position = canPos;
                }
                canObject.transform.Rotate(0, -120*Time.deltaTime, 0);
                if(canPos.z >= -4.5){
                    Destroy(canObject);
                    canCreated = 0;
                    arg = 0;
                }
            }
        }
    }
}
