using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePitch : MonoBehaviour
{

    private AudioSource audioSource;
    private float pitch;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 0.0f;
    }




}



