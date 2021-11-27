using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomShrink : MonoBehaviour
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
        if(roomScale.x > 0.7){
            roomScale.x -= 0.0005f;
            roomScale.y -= 0.0005f;
            roomScale.z -= 0.0005f;
            room.transform.localScale = roomScale;
        }
    }
}
