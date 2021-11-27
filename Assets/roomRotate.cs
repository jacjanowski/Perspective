using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomRotate : MonoBehaviour
{

    public GameObject room;
    public GameObject player;
    private Vector3 playerPos;

    public void up(){
        room.transform.Rotate(90,0,0);
        tpPlayer();
    }

    public void left(){
        room.transform.Rotate(0,0,90);
        tpPlayer();
    }

    public void right(){
        room.transform.Rotate(0,0,-90);
        tpPlayer();
    }

    public void down(){
        room.transform.Rotate(-90,0,0);
        tpPlayer();
    }

    private void tpPlayer(){
        playerPos = player.transform.position;
        playerPos.x = 4.726059f;
        playerPos.y = 4.504f;
        playerPos.z = 1.47131f;
        player.transform.position = playerPos;

    }
}