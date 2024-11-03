using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras_control : MonoBehaviour
{
    public GameObject SideCam;
    public GameObject TopCam;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            SideCam.SetActive(true);
            TopCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            TopCam.SetActive(true);
            SideCam.SetActive(false);
        }
    }
}
