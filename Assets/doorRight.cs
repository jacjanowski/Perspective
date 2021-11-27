using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorRight : MonoBehaviour
{

    public GameObject door;
    private Vector3 doorPosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        doorPosition = door.transform.position;
        if (doorPosition.x < 1.0)
        {
            doorPosition.x += 0.005f;
            door.transform.position = doorPosition;
        }
    }
}
