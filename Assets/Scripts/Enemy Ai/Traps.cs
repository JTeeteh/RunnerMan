using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Traps : MonoBehaviour
{

    [SerializeField]
    private float minTrigDist = 0;
    [SerializeField]
    private float maxTrigDist = 10;

    private float triggerDist;

    private Transform player;
    private float playerDistance;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        playerDistance = Vector3.Distance(transform.position, player.position);
        triggerDist = Random.Range(minTrigDist, maxTrigDist);
        if (playerDistance < triggerDist)
        {
            Trigger();
        }
    }

    protected abstract void Trigger();
}
