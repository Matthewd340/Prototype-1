using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 5, -10);
    Vector3 firstPersonOffset = new Vector3(0, 2, 1);
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = player.transform.position + offset;

      if (Input.GetKey(KeyCode.LeftShift))
      {
        transform.position = player.transform.position + firstPersonOffset;
        transform.rotation = player.transform.rotation;
      }

      
    }
}


