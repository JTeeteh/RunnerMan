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
        audioSource.pitch = 0.002f;
        audioSource.volume = 0.75f;




    }

    void Update()
    {

        audioSource.pitch += 0.01f * Time.deltaTime;
        audioSource.volume -= 0.01f * Time.deltaTime;
    }
  
}



