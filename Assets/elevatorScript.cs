using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorScript : MonoBehaviour
{
    public GameObject elevator;
    private Vector3 elevatorPosition;
    private bool goingUp = false;

    public void upOrDown(bool up){
        goingUp = up;
    }

    // Update is called once per frame
    void Update()
    {
        elevatorPosition = elevator.transform.position;
        if(goingUp){
            if(elevatorPosition.y < 5.08){
                elevatorPosition.y += 0.005f;
                elevator.transform.position = elevatorPosition;
            }
        }
        else{
            if(elevatorPosition.y > -1.68){
                elevatorPosition.y -= 0.005f;
                elevator.transform.position = elevatorPosition;
            }
        }
    }
}
