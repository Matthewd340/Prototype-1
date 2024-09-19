﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 10.0f;
    private float verticalInput;
    public AudioSource collideSound;

    // Start is called before the first frame update
    void Start()
    {
        collideSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }

    private void OnCollisionEnter (Collision collision)
    {
        collideSound.Play();
    }
}
