using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera leftCamera;
    public Camera rightCamera;
    public Camera leftFirstPersonCamera;
    public Camera rightFirstPersonCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
      {
        SwapLeftCameras();
      }      
      //toggles cameras for player 1
      
        else if (Input.GetKeyDown(KeyCode.LeftShift))
      {
        SwapRightCameras();
      }
      //toggles cameras for player 2
    }

    void SwapLeftCameras()
    {
        if (leftCamera.enabled == true)
      {
        leftCamera.enabled = false;
      }
        
        else if (leftCamera.enabled == false)
      {
        leftCamera.enabled = true;
      }

      if (leftFirstPersonCamera.enabled == true)
      {
        leftFirstPersonCamera.enabled = false;
      }

        else if (leftFirstPersonCamera.enabled == false)
      {
        leftFirstPersonCamera.enabled = true;
      }
      //enables and disables cameras accorind to which ones are active and inactive for P1


    }

    void SwapRightCameras()
    {
        if (rightCamera.enabled == true)
      {
        rightCamera.enabled = false;
      }
        
        else if (rightCamera.enabled == false)
      {
        rightCamera.enabled = true;
      }

      if (rightFirstPersonCamera.enabled == true)
      {
        rightFirstPersonCamera.enabled = false;
      }

        else if (rightFirstPersonCamera.enabled == false)
      {
        rightFirstPersonCamera.enabled = true;
      }
      //enables and disables cameras accorind to which ones are active and inactive for P2
    }
    
}
