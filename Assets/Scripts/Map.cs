using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public Camera PlayCam;
    public Camera MapCam;

    void Start()
    {
        PlayCam.enabled = PlayCam.enabled;
        MapCam.enabled = !MapCam.enabled;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            //Swap enabled state to opposite one provided that only is on at a time
            PlayCam.enabled = !PlayCam.enabled;
            MapCam.enabled = !MapCam.enabled;
        }
    }
}
