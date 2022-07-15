using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyprefab;
    [SerializeField]
    private List<Transform> spawnpoint;
    [SerializeField]
    float spawndelay;
    [SerializeField]
    private int enemycountmin = 1, enemycountmax = 1;
    public int enemycount;
    float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
    }

    private void spawn()
    {
        currentTime = currentTime + Time.deltaTime;
        if (currentTime > spawndelay)
        {
            for (int i = 0; i < enemycount; i++)
            {
                //Instantiate(enemyprefab, spawnloc);
            }
        }
    }
}