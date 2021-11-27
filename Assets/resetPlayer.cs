using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPlayer : MonoBehaviour
{
    public GameObject player;

    public void reset(){
        Debug.Log(player.transform.position);
        player.transform.position = new Vector3(2.5f, -0.2f, 0f);
    }

}
