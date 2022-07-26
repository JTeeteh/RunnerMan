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
        audioSource.pitch = 0.02f;
        audioSource.volume = 0.05f;




    }

    void Update()
    {

        audioSource.pitch += 0.001f * Time.deltaTime;
        audioSource.volume += 0.001f * Time.deltaTime;
    }
  
}



