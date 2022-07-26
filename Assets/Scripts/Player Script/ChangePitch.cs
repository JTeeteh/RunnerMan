using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangePitch : MonoBehaviour
{

    private AudioSource audioSource;
    


    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 0.2f;
     




    }

    void Update()
    {

        audioSource.pitch += 0.0001f * Time.deltaTime;

    }
  
}



