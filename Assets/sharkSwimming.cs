using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkSwimming : MonoBehaviour
{
    public GameObject shark;
    private Vector3 sharkPosition;
    public bool goingForward;

    // Update is called once per frame
    void Update()
    {
        sharkPosition = shark.transform.position;
        if(sharkPosition.z < 2.0 && goingForward){
            sharkPosition.z += 0.005f;
            shark.transform.position = sharkPosition;
        }
        else if(sharkPosition.z >= 2.0){
            goingForward = false;
            shark.transform.Rotate(0,180,0);
        }

        if(sharkPosition.z > -2.1 && !goingForward){
            sharkPosition.z -= 0.005f;
            shark.transform.position = sharkPosition;
        }
        else if(sharkPosition.z <= -2.1){
            goingForward = true;
            shark.transform.Rotate(0,180,0);
        }
    }
}
