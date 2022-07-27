using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Kino;
public class Scene_Transfer : MonoBehaviour
{
    [SerializeField] private DigitalGlitch GlitchEffect;
    [SerializeField] private float Intensity;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision is BoxCollider)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
    





    private void OnTriggerStay(Collider collider)
    {
        if (collider is SphereCollider)
        {
            {
                Vector3 distanceVector = collider.transform.position - transform.position;

                GlitchEffect.intensity = Intensity / distanceVector.magnitude;
            }
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider is SphereCollider)
        {
            GlitchEffect.intensity = 0;
        }
    }

}
