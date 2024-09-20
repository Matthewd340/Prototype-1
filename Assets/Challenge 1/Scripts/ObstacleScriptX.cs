using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScriptX : MonoBehaviour
{
    public AudioSource collideSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        private void OnCollisionEnter (Collision collision)
    {
        collideSound.Play();
    }
}
