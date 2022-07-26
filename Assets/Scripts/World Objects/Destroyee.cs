using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyee : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
