using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePitch : MonoBehaviour
{

    private AudioSource audioSource;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 0.4f;
       
       
        

    }
    
  void Update()
    {
        audioSource.pitch += 0.01f * Time.deltaTime;
    }

  

}



