using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //allows speed to be edited form inspector
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
