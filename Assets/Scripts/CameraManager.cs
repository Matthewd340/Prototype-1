using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera mainCamera;
    public Camera firstPersonCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
      {
        SwapCameras();
      }
    }

    void SwapCameras()
    {
        if (mainCamera.enabled == true)
      {
        mainCamera.enabled = false;
      }
        
        else if (mainCamera.enabled == false)
      {
        mainCamera.enabled = true;
      }

      if (firstPersonCamera.enabled == true)
      {
        firstPersonCamera.enabled = false;
      }

        else if (firstPersonCamera.enabled == false)
      {
        firstPersonCamera.enabled = true;
      }

    }
    
}
