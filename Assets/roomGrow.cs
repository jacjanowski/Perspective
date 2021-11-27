using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomGrow : MonoBehaviour
{

    public GameObject room;
    private Vector3 roomScale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roomScale = room.transform.localScale;
        if(roomScale.x < 1){
            roomScale.x += 0.001f;
            roomScale.y += 0.001f;
            roomScale.z += 0.001f;
            room.transform.localScale = roomScale;
        }
    }
}
